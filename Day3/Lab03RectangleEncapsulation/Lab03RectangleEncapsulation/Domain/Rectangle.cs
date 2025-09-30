

namespace InsiteInternational.Domain
{
     class Rectangle
    {
        private int _width=1;
        private int _height=1;
        private string _color="red";
      

        public void SetWidth(int width) {

            if (width > 1 && width < 100)
            {
                _width = width;
            }
           
        }

        public int GetWidth() {

            return _width;
        }

        public void SetHeight(int height) {
            if (height > 1 && height < 100)
            {
                _height = height;
            }
        
        }

        public int GetHeight() {
            return _height;
        }

        public void SetColor(string color) {

            if (color == "red" || color == "blue" || color == "green") 
            { 
              _color = color;
            }
        
        }

        public string GetColor() { 
        
            return _color;
        }



        public int CalculateArea() {
            return  _width * _height;
        }
    }
}
