    using BenchmarkDotNet.Attributes;
    [MemoryDiagnoser]
    public class BenchMarkTest
    {
        
        [Benchmark]
        public void MyTest()
        {
            var locationDetails = new List<string>() { "loc1", "loc2", "loc3", "loc1", "loc2", "loc3", "loc1", "loc2", "loc3", "loc1", "loc2", "loc3", "loc1", "loc2", "loc3"};

            var compressedXML = @"test";
            // Study Authority call to send the received ancillary notification to Gold Copy locations.
            foreach (var Location in locationDetails)
            {
                using (var stream = GenerateStreamFromString(compressedXML))
                {
                    Task.Delay(5000);
                    DoSomeWork(stream);
                }
            }
        }
        private void DoSomeWork(Stream s)
        {
            using(StreamReader reader = new StreamReader(s))
            {
              Console.WriteLine(reader.ReadToEnd());
            }

        }

        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

    }