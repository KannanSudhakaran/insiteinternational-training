
namespace InsiteInternaitonal
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;
        private BorderStyleOption _borderStyle;



        public BorderStyleOption Border {

            get { return _borderStyle; }
            set {
                _borderStyle = value;
            
            }
        }


        public string Color { 
        
            get { return _color; }
            set {
                if (value == "red" || value == "blue" || value == "green")
                {
                    _color = value;
                }
                else
                    _color = "red";
            
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 1)
                {
                    _height = 1;
                }
                else if (value > 100)
                {
                    _height = 100;
                }
                else
                {
                    _height = value;
                }
            }

        }
        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value < 1)
                    _width = 1;
                else if (value > 100)
                    _width = 100;
                else
                    _width = value;

            }
        }

        public int CalcuateArea() { 
         return _width * _height;
        }

    }
}
