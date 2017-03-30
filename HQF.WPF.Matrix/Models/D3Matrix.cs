namespace HQF.WPF.Matrix.Models
{
    public class D3Matrix
    {
        public double M11 { get; set; }
        public double M12 { get; set; }

        public double M13 { get; set; }

        public double M21 { get; set; }
        public double M22 { get; set; }

        public double M23 { get; set; }

        public double M31 { get; set; }

        public double M32 { get; set; }

        public double M33 { get; set; }


        public static D3Matrix FroMatrix(System.Windows.Media.Matrix matrix)
        {
            var result=new D3Matrix()
            {
                M11 = matrix.M11,
                M12 = matrix.M12,
                M13 = 0,
                M21 = matrix.M21,
                M22 = matrix.M22,
                M23 = 0,
                M31 = matrix.OffsetX,
                M32 = matrix.OffsetY,
                M33 = 1
            };

            return result;
        }

        public System.Windows.Media.Matrix ToMatrix()
        {
            var result = new System.Windows.Media.Matrix()
            {
                M11 = this.M11,
                M12 = this.M12,
                M21 = this.M21,
                M22 = this.M22,
                OffsetX = this.M31,
                OffsetY = this.M32
            };
             return result;
        }
    }
}