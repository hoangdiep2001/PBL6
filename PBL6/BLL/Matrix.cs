using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL6
{
    public class Matrix
    {
        public float m1 { get; set; }
        public float m2 { get; set; }
        public float m3 { get; set; }

        public float m4 { get; set; }

        private static Matrix _Instance;

        public Matrix(float a1, float a2, float a3, float a4)
        { 
               
            m1 = a1;
            m2 = a2;
            m3 = a3;
            m4 = a4;

        }

        public static Matrix Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new Matrix();

                }
                return _Instance;
            }

        }

        public Matrix()
        {

        }

        //public string matrixDN(float m1,float m2,float m3,float m4)
        //{
        //    string matran_str = ""; 
        //    float n1, n2, n3, n4;
        //    float det = 1 / (m1 * m4 - m2 * m3);
        //    n1 = m4 * det;
        //    n2 = -m2 * det;
        //    n3 = -m3 * det;
        //    n4 = m1 * det;
        //    matran_str = n1.ToString() + "a" + n2.ToString() + "a" + n3.ToString() + "a" + n4.ToString();

        //    return matran_str;

        public Matrix matrixDN()
        {
            Matrix mtr = new Matrix();
            
            float det = 1 / (m1 * m4 - m2 * m3);
            mtr.m1 = this.m4 * det;
            mtr.m2 = -this.m2 * det;
            mtr.m3 = -this.m3 * det;
            mtr.m4 = this.m1 * det;        
            return mtr;

        }
        public Matrix Tich_mtr( Matrix B)
        {
            Matrix C = new Matrix();
            float a, b, c, d;
            a = this.m1 * B.m1 + this.m2 * B.m3;
            b = this.m1 * B.m2 + this.m2 * B.m4;
            c = this.m3 * B.m1 + this.m4 * B.m3;
            d = this.m3 * B.m2 + this.m4 * B.m4;
            C.m1 = a;
            C.m2 = b;
            C.m3 = c;
            C.m4 = d;

            return C;

        }

     

        public float Number_modP(float a, int P)
        {
            if (a >= 0)
            {
                float x = a % P;
                return x;
            }
            else
            {
                for (float i = 0; i < P; i++)
                {
                    if ((-a + i) % P == 0)
                        return i;
                }
            }
            return 0;
        }









        //}


    }
    
}
