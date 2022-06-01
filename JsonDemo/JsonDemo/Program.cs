namespace JsonDemo
{
    class program
    {
        public static void Main(string[] args)
        {

            Read read = new JsonDemo.Read();

            Rice data = read.ReadTheData("C:/Users/003INX744/source/repos/154/LsonDemo/");

            Console.WriteLine(data.price);
            Console.WriteLine(data.name);
            Console.WriteLine(data.weight);

        }

    }

}