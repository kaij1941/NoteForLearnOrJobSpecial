 //SituationB 
 //編程式(Imperative)：(lambda)
    public class TestService : ITestService
    {
        public async Task Test()
        {
            List<Product> pList = new List<Product>();
            pList.Add(new Product() { Code = "A", Name = "A1", QTY = "3" });
            pList.Add(new Product() { Code = "A", Name = "A2", QTY = "3" });
            pList.Add(new Product() { Code = "A", Name = "A1", QTY = "" });

            var linqTest = await pList
                .GroupBy(x => new { x.Code, x.Name })
                .Select(
                        new
                        {
                            Code = g.Key.Code,
                            Name = g.Key.Name,
                            QTY = g.Sum(p => checkIsNumAwait(p.QTY)? p.QTY:0)
                        }
                    );
            foreach (var query in linqTest)
            {
                string s = string.Format("Code: {0}, Name: {1}, QTY={2} <BR />", query.Code, query.Name, query.QTY);
                Console.WriteLine(s);
            }
        }
        public bool checkIsNumAwait(string Test) 
        {
            if (Test == null &&Test.Length<1)
            {
                return false;
            }
            var checkArray = Test.ToCharArray();
            foreach (var item in checkArray)
            {
                if (char.IsNumber(item).Equals(false)) 
                {
                    return false;
                }
            }
            return true;
        }

    }
    public class Product 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string QTY { get; set; }
    }
