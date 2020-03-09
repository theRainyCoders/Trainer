using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace TheRainyCoders.Trainer.Lib.TrainingZones.Calculators.Tests
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            var pace = "05:15"; // min/km

            var regex = new Regex(@"\d*:\d*");
            var result = regex.Match(pace);


            if (result.Success == false)
            {
                return;
            }

            var l = result.Value.Split(':');
            var minutes = int.Parse(l[0], NumberStyles.Integer, CultureInfo.InvariantCulture);
            var seconds = int.Parse(l[1], NumberStyles.Integer, CultureInfo.InvariantCulture);

            var paceInSecPerKm = minutes * 60 + seconds;

            //paceInSecPerKm.Should().Be(271);

            var onePercent = paceInSecPerKm / 100D;
            
            // below 100%
            var regDlMin = paceInSecPerKm + (onePercent *  65);

            // over 100%
            //var regDl = paceInSecPerKm - onePercent *  (100 + 10);

            var one = (int)Math.Truncate(regDlMin / 60);
            var two = (int)Math.Truncate(regDlMin % 60);
            
            var zoneOneMin = $"{one:D2}:{two:D2}"; 
         }

        [Fact]
        public void SwimCss()
        {
            //var time400m = "00:7:00";
            //var time200m = "00:3:20";
            var time400m = "00:6:36";
            var time200m = "00:3:07";

            //var pace = "00:05:15"; // min/km

            //var regex = new Regex(@"\d*:\d*");
            //var result = regex.Match(pace);


            //if (result.Success == false)
            //{
            //    return;
            //}

            //var l = result.Value.Split(':');
            //var minutes = int.Parse(l[0], NumberStyles.Integer, CultureInfo.InvariantCulture);
            //var seconds = int.Parse(l[1], NumberStyles.Integer, CultureInfo.InvariantCulture);


            TimeSpan duration400m = TimeSpan.Parse(time400m, CultureInfo.InvariantCulture);
            TimeSpan duration200m = TimeSpan.Parse(time200m, CultureInfo.InvariantCulture);

            var css = 100 / ((400 - 200) / (duration400m - duration200m).TotalSeconds);



            TimeSpan cssSpan = TimeSpan.FromSeconds(css);

            

            double onePercent = css / 100; 

            var rangeMin = TimeSpan.FromSeconds(onePercent * 122);
            var rangeMax = TimeSpan.FromSeconds(onePercent * 111);

            this.output.WriteLine("Kompensationsbereich 122-111%: {0} - {1}", rangeMin, rangeMax);

            rangeMin = TimeSpan.FromSeconds(onePercent * 110);
            rangeMax = TimeSpan.FromSeconds(onePercent * 108);

            this.output.WriteLine("Grundlagenausdauer 1 110-108%: {0} - {1}", rangeMin, rangeMax);

            rangeMin = TimeSpan.FromSeconds(onePercent * 107);
            rangeMax = TimeSpan.FromSeconds(onePercent * 103);

            this.output.WriteLine("Grundlagenausdauer 2 107-103%: {0} - {1}", rangeMin, rangeMax);

            rangeMin = TimeSpan.FromSeconds(onePercent * 102);
            rangeMax = TimeSpan.FromSeconds(onePercent * 98);

            this.output.WriteLine("Entwicklungsbereich 102-98%: {0} - {1}", rangeMin, rangeMax);

            rangeMin = TimeSpan.FromSeconds(onePercent * 97);
            rangeMax = TimeSpan.FromSeconds(onePercent * 94);

            this.output.WriteLine("Aerobe Kapazitaet 97-94%: {0} - {1}", rangeMin, rangeMax);

            rangeMin = TimeSpan.FromSeconds(onePercent * 93);

            this.output.WriteLine("Anerobe Kapazitaet <= 93%: {0}", rangeMin);
        }




    }
}