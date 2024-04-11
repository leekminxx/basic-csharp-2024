namespace ex06_properties
{
    class kiturami
    {
        public int temperature; // 온도

        public int Temperature
        {
            get
            {   // 갑을 리턴하니까 특별한 기능이 없음
                return temperature;
            }
            set
            {   // 잘못된 값이 들어오면 안되기 때문에 여러 제약을 걸어줌 
                if (value < 10)
                    temperature = 20;
                else if (value > 70)
                    temperature = 50; //70도 초과는 허용안함
                else
                    temperature = value;
            }
        }
        
        //    public void SetTemperature(int temp)
        //    {
        //        if (temp > 70)
        //        {
        //            Console.WriteLine("온도가 너무 높습니다. 50도로 조정합니다/");
        //            this.temperature = 50;
        //        }
        //        else if (temp < 10)
        //        {
        //            Console.WriteLine("온도가 너무 낮습니다. 20도로 조정합니다/");
        //            this.temperature = 20;
        //        }
        //        else
        //        {
        //            this.temperature = temp;
        //        }
        //    }

        //    public int GetTemperature()
        //    {
        //        return this.temperature;
        //    }

        public void On()
        {
            Console.WriteLine("보일러 On");
        }

        public void off()
        {
            Console.WriteLine("보일러 off");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보일러 시작!");
            kiturami boiler = new kiturami();
            //boiler.temperature = 400;  //막아버림
            //Console.WriteLine($"보일러 온도는 {boiler.temperature}도");  //막아버림 
            //boiler.SetTemperature = 400;  //막아버림

            //boiler.On();
        }
    }
}
