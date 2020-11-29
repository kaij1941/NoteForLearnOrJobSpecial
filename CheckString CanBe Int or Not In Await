//Fuction For C# to CheckString CanBe Int or Not In Await
//Do it Because Int32.tryParse must use out,But it Can't work in Await

        public static bool checkIsNumAwait(string Test)
        {
            if (Test == null || Test.Length < 1)
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
