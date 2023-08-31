namespace parcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static readonly List<BoxSize> boxSizes = new List<BoxSize>
        {
            new BoxSize
            {
                Length = 120,
                Width = 60,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam()
                    {
                        LineWidth = 100
                    },
                    new SortingLineParam()
                    {
                        LineWidth = 75
                    }
            }
            },
            new BoxSize
            {
                Length = 100,
                Width = 35,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        LineWidth = 75
                    },
                    new SortingLineParam
                    {
                        LineWidth= 50
                    },
                    new SortingLineParam
                    {
                        LineWidth = 80
                    },
                    new SortingLineParam
                    {
                        LineWidth= 100
                    },
                    new SortingLineParam
                    {
                        LineWidth= 37
                    }
                }
            },
            new BoxSize
            {
                Length = 70,
                Width = 50,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        LineWidth = 60
                    },
                    new SortingLineParam
                    {
                        LineWidth= 60
                    },
                    new SortingLineParam
                    {
                        LineWidth = 55
                    },
                    new SortingLineParam
                    {
                        LineWidth= 90
                    }
                }
            }
        };
    }

    public class BoxSize
    {
        public int Length { get; set; }
        public int Width {  get; set; }

        public List<SortingLineParam> SortingLineParams { get; set; } = new List<SortingLineParam>();
    }
    public class SortingLineParam
    {
        public int LineWidth { get; set; }
    }
}