using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PBL6.DTO;


namespace PBL6.View
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        


        private void ButMH_Click(object sender, EventArgs e)
        {

        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    Random rand = new Random();
        //    int a;
        //    int b;
        //    string a1_tr;
        //    string a2_tr;




        //    do
        //    {
        //        a = rand.Next(1, 100);
        //        b = rand.Next(1, 100);

        //        a1_tr = a.ToString();
        //        a2_tr = b.ToString();



        //    }

        //    while (ucln(a, b) == false
        //    ) ;

        //    // MessageBox.Show(a1_tr + " va " + a2_tr);
        //    txtA1.Text = a1_tr;
        //    txtA2.Text = a2_tr;
        //    txtA3.Text = a2_tr;
        //    txtA4.Text = a1_tr;

        //    txtP1.Text = txtBanMa1.Text;





        //}

        private void btImport1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                txtBanMa1.Text = read.ReadToEnd();
                read.Close();

            }
        }



        private void btExport1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "|*.txt";
            save.RestoreDirectory = true;
            if(save.ShowDialog()== DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.WriteLine(txtBanRo1.Text);
                writer.Close();
            }

            MessageBox.Show("Export done");
        }

        private void btRefresh1_Click(object sender, EventArgs e)
        {
          //  txtP1.Text = "";
            txtG1.Text = "";
            txtG2.Text = "";
            txtG3.Text = "";
            txtG4.Text = "";
            txtA1.Text = "";
            txtA2.Text = "";
            txtA3.Text = "";
            txtA4.Text = "";
            txtBanRo1.Text = "";
            txtBanMa1.Text = "";
        }

        public bool ucln(int a, int b)
        {
            if (a < 0)
            {
                a = -a;

            };
            if(b<0)
            {
                b = -b;
            }
            
            int ucln=1;
            int i = 1;
            int j ;
            j = (a < b) ? a : b;
            for(i=1;i<=j;i++)
            {
                if(a%i ==0 && b%i ==0)
                {
                    ucln = i;

                }
            }

            if (ucln == 1) return true;
            else return false;


        }


        private void btTich2MaTran_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dap an la "+KK(5,11).ToString());
            //if (txtA1.Text.Trim()=="" || txtA2.Text.Trim() == "" || txtA3.Text.Trim() == "" || txtA4.Text.Trim() == ""
            //    || txtG1.Text.Trim() == ""|| txtG2.Text.Trim() == ""|| txtG3.Text.Trim() == ""|| txtG4.Text.Trim() == ""
            //    || txtP1.Text.Trim() == "")
            //{
            //    MessageBox.Show(" thong tin khoa P,A,G còn thiếu !!!");


            //}   
            
            //else
            //{
            //    Matrix X = new Matrix();
            //    Matrix A = new Matrix();
            //    Matrix B = new Matrix();

            //    A.m1 = float.Parse(txtA1.Text);
            //    A.m2 = float.Parse(txtA2.Text);
            //    A.m3 = float.Parse(txtA3.Text);
            //    A.m4 = float.Parse(txtA4.Text);


            //    B.m1 = float.Parse(txtG1.Text);
            //    B.m2 = float.Parse(txtG2.Text);
            //    B.m3 = float.Parse(txtG3.Text);
            //    B.m4 = float.Parse(txtG4.Text);

            //    MessageBox.Show(" gia tri khi nhan 2 ma tran la " + A.Tich_mtr(B).m1.ToString()+"a" + A.Tich_mtr( B).m2.ToString() + "a"
            //        + A.Tich_mtr(B).m3.ToString() + "a"
            //        + A.Tich_mtr( B).m4.ToString() + "a");
                

            //}    

        }

        private void btMatrixNd_Click(object sender, EventArgs e)
        {
           
            Matrix A = new Matrix();
            Matrix P_A = new Matrix();
            //  int P = Convert.ToInt32(txtP1.Text);
            int P = 29;

            A.m1 = float.Parse(txtA1.Text);
            A.m2 = float.Parse(txtA2.Text);
            A.m3 = float.Parse(txtA3.Text);
            A.m4 = float.Parse(txtA4.Text);


           

            float det_A_nd = Number_NghichDao(A, P);

            P_A.m1 = A.m4*det_A_nd;
            P_A.m2 = -A.m2 * det_A_nd;
            P_A.m3 = -A.m3 * det_A_nd;
            P_A.m4 = A.m1 * det_A_nd;




            MessageBox.Show(" ket qua la " + matrix_mod_P(P_A, P).m1.ToString()+"a"
                + matrix_mod_P(P_A, P).m2.ToString() + "a"
                + matrix_mod_P(P_A, P).m3.ToString() + "a"
                + matrix_mod_P(P_A, P).m4.ToString() + "a"+"nghic dao la "+ det_A_nd);






            //Matrix matrix = new Matrix(3, 4, 4, 3);
            //MessageBox.Show(" mtr nd la " + matrix.matrixDN().m1.ToString()+"a" + matrix.matrixDN().m2.ToString() + "a"
            //    + matrix.matrixDN().m3.ToString() + "a" + matrix.matrixDN().m4.ToString() + "a");

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            //Matrix G = new Matrix(17, 19, 29, 37);
            //int n = 4;
            //int[,] a = new int[,]
            //    {
            //        {(int)G.m1,(int)G.m2,(int)G.m3,(int)G.m4 },
            //        {(int)G.m2,(int)G.m1,(int)G.m4,(int)G.m3 },
            //        {(int)G.m3,(int)G.m4,(int)G.m1,(int)G.m2 },
            //        {(int)G.m4,(int)G.m3,(int)G.m2,(int)G.m1 }



            //    };

            //   MessageBox.Show("dinh thuc ma tran G_c la " + KT_detGc());


            Matrix P_A = new Matrix();
            Matrix A_1 = new Matrix();
            float det_A_nd;
            Matrix A = new Matrix();
            Matrix A_nd = new Matrix();
            Matrix B = new Matrix();
            Matrix AB = new Matrix();
            Matrix K = new Matrix();
            A.m1 = float.Parse(txtA1.Text);
            A.m2 = float.Parse(txtA2.Text);
            A.m3 = float.Parse(txtA3.Text);
            A.m4 = float.Parse(txtA4.Text);
            //   int P = Convert.ToInt32(txtP1.Text.ToString());
            int P = 29;


            B.m1 = float.Parse(txtG1.Text);
            B.m2 = float.Parse(txtG2.Text);
            B.m3 = float.Parse(txtG3.Text);
            B.m4 = float.Parse(txtG4.Text);
            det_A_nd = Number_NghichDao(A, P);

            P_A.m1 = A.m4 * det_A_nd;
            P_A.m2 = -A.m2 * det_A_nd;
            P_A.m3 = -A.m3 * det_A_nd;
            P_A.m4 = A.m1 * det_A_nd;

            A_1 = matrix_mod_P(P_A, P);
            K = A.Tich_mtr(B);
            K = K.Tich_mtr(A_1);
            K = matrix_mod_P(K, P);

            MessageBox.Show("gia tri la " + K.m1.ToString() + "a" + K.m2.ToString() + "a" + K.m3.ToString() +
                "a" + K.m4.ToString() + "a");
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {

            string s = txtBanMa1.Text.Trim().ToString();
            string banro = s;
            //string banro = "JDHFJDJD";

            // string banro = "ADDIDAII";



            Matrix A = new Matrix();
            Matrix A_1 = new Matrix();
            Matrix G = new Matrix();
            Matrix K = new Matrix();
            //Matrix2 C = new Matrix2();
          //  Matrix2 M = new Matrix2();
            Matrix2 V1 = new Matrix2();
            Matrix2 V2 = new Matrix2();
            Matrix P_A = new Matrix();
            int P;
            float det_A_nd;
            if (kt_dinhdang_vanban()== false)
            {
                MessageBox.Show("Lỗi văn bản");
            }
            else
            {
                if(matrixA_modunP_matrixG_dinhdang() == false)
                {
                    MessageBox.Show("Lỗi dinh dạng P, A, G");
                }
                else
                {

                    P = 29;

                    A.m1 = float.Parse(txtA1.Text);
                    A.m2 = float.Parse(txtA2.Text);
                    A.m3 = float.Parse(txtA3.Text);
                    A.m4 = float.Parse(txtA4.Text);
                 

                    switch (matrixA_modunP_matrixG_logic(A, P) )
                    {
                        case 1:
                            MessageBox.Show("P phải là số nguyên tố! ");
                            break;
                        case 2:
                            MessageBox.Show("Ma trận A phải là ma trận nguyên tố! ");
                            break;
                        case 3:
                            MessageBox.Show("P và det(A) phải nguyên tố cùng nhau!");
                            break;
                        case 4:
                            MessageBox.Show("det(G_c) phải có giá trị bằng 0 ");
                            break;
                        case 0:
                            // P = Convert.ToInt32(txtP1.Text.ToString());
                            P = 29;

                            A.m1 = float.Parse(txtA1.Text);
                            A.m2 = float.Parse(txtA2.Text);
                            A.m3 = float.Parse(txtA3.Text);
                            A.m4 = float.Parse(txtA4.Text);

                            G.m1 = float.Parse(txtG1.Text);
                            G.m2 = float.Parse(txtG2.Text);
                            G.m3 = float.Parse(txtG3.Text);
                            G.m4 = float.Parse(txtG4.Text);
                            det_A_nd = Number_NghichDao(A, P);

                            P_A.m1 = A.m4 * det_A_nd;
                            P_A.m2 = -A.m2 * det_A_nd;
                            P_A.m3 = -A.m3 * det_A_nd;
                            P_A.m4 = A.m1 * det_A_nd;

                            A_1 = matrix_mod_P(P_A, P);

                            K = A.Tich_mtr(G);
                            K = K.Tich_mtr(A_1);
                            K = matrix_mod_P(K, P);
                         //   MessageBox.Show(K.m1.ToString() + "a" + K.m2.ToString() + "a" + K.m3.ToString() + "a" +
                              //  K.m4.ToString() + "a");

                           V1.n1 = A.m1;
                            V1.n2 = A.m2;

                           V2.n1 = A.m2;
                            V2.n2 = A.m1;

                            // MessageBox.Show(mahoa(banro, K, V1, V2,P));
                            txtBanRo1.Text = (mahoa(banro, K, V1, V2, P));









                            break;
                       
                    }
                }
            }


           

           
            }






        

        public bool kt_ThieuthongTin()
        {
            //if ((txtA1.Text.Trim() == "") || (txtA2.Text.Trim() == "") || (txtA3.Text.Trim() == "") ||
            //    (txtA4.Text.Trim() == "") || (txtG1.Text.Trim() == "") || (txtG2.Text.Trim() == "") ||
            //    (txtG3.Text.Trim() == "") || (txtG4.Text.Trim() == "") || (txtP1.Text.Trim() == "")

            //    )
                return false;
            //else return true;
        }

        public bool kt_thongtin_hople()
        {

            return true;

        }

        public  Matrix random_A()
        {

            Matrix A = new Matrix();
            Random rand = new Random();
            int a;
            int b;
            int det;
      

            do
            {
                a = rand.Next(1, 100);
                b = rand.Next(1, 100);

                A.m1 = a;
                A.m2 = b;
                A.m3 = b;
                A.m4 = a;
                det = a * a - b * b;


            }

            while (ucln(a, b) == false || (ucln(det,29) == false)
            );


            return A;

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
        public Matrix matrix_mod_P(Matrix K, int P)
        {
            Matrix a = new Matrix();
            a.m1 = Number_modP(K.m1, P);
            a.m2 = Number_modP(K.m2, P);
            a.m3 = Number_modP(K.m3, P);
            a.m4 = Number_modP(K.m4, P);

            return a;
        }


        public float Number_NghichDao(Matrix A, int P)
        {
           


            float dinhthuc_A = A.m1 * A.m4 - A.m3 * A.m2;

            if(dinhthuc_A>0)
            {
                for(int i=1;i<99999;i++)
                {
                    if ((dinhthuc_A * i) % P == 1)
                    {
                    return i;
                    }
                }
            }
            else
            {
                for (int i = 1; i < 99999; i++)
                {
                    if ((-dinhthuc_A * i) % P == 1)
                    {
                        return -i;
                    }
                }

            }



            return 0;



        }

        public double test()
        {
            double a = 0;
           // double b = 0;

            a = Math.Pow(7, 27) % 29;
          //  b = (-7) * a;
            return a;

        }

        public  int det(int[,] a, int n)
        {

            int d = 0;
            if (n <= 0) return 0;
            if (n == 1) return a[0, 0];
            if (n == 2) return (a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0]);
            else
            {
                int[,] c = new int[n - 1, n - 1]; //Ma trận con cấp n-1
                //Khai triển định thức theo cột đầu tiên (cột 0)
                for (int j = 0; j < n; j++)
                {
                    //Tạo ma trận con c cấp n-1 bằng cách bỏ đi cột 0 và hàng j của ma trận a
                    int p = 0; int m = 0;
                    for (int i = 1; i < n; i++)
                    {
                        for (int e = 0; e < n; e++)
                        {
                            if (e == j) continue;
                            c[p, m] = a[e, i];
                            p++;
                            if (p == n - 1)
                            {
                                m++;
                                p = 0;
                            }
                        }
                    }

                    d += ((int)Math.Pow(-1, j) * a[j, 0] * det(c, n - 1));
                }
                return d;
            }
        }

        public bool KT_detGc()
        {
            Matrix G = new Matrix();
            G.m1 = float.Parse(txtG1.Text);
            G.m2 = float.Parse(txtG2.Text);
            G.m3 = float.Parse(txtG3.Text);
            G.m4 = float.Parse(txtG4.Text);

            int n = 4;
            int[,] a = new int[,]
                {
                    {(int)G.m1,(int)G.m2,(int)G.m3,(int)G.m4 },
                    {(int)G.m2,(int)G.m1,(int)G.m4,(int)G.m3 },
                    {(int)G.m3,(int)G.m4,(int)G.m1,(int)G.m2 },
                    {(int)G.m4,(int)G.m3,(int)G.m2,(int)G.m1 }



                };

            if(det(a, n) == 0)
            {
                return true;

            }
            return false;

           

        }


        public string font_Norman(string str1)
        {

            return "aaa";

        }

        ///////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        ////                                 CÁC HÀM XỬ LÍ CHUỖI     
        //////////////////////


        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtBanMa1.Text.Trim().ToString();
            string banro = s;
            int P =29;

            Matrix K = new Matrix(2, 24, 10, 3);


            Matrix2 V1 = new Matrix2(3, 4);
            Matrix2 V2 = new Matrix2(4, 3);
            //Matrix K = new Matrix(2, 24, 10, 3);
            //Matrix2 M = new Matrix2(1, 4);
            //Matrix2 V = new Matrix2(3, 4);         
            //Matrix2 matrix = new Matrix2();
            //int P = 29;

            //matrix.n1= Mi_to_Ci(K, M, V, P).n1;
            //matrix.n2 = Mi_to_Ci(K, M, V, P).n2;


            txtBanRo1.Text = (mahoa(banro, K, V1, V2, P));
          //  MessageBox.Show(mahoa(banro,K,V1,V2,P));
        }


        public Matrix2 anphalbet_to_number(string a1, string a2)
        {
            Matrix2 M = new Matrix2();
           
            string[] quyuoc = {"A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"
            ,"P","Q","R","S","T","U","V","W","X","Y","Z","@","#","&"};

            for(int i=0;i<=28;i++)
            {
                if(quyuoc[i] == a1) { M.n1 = i; }
            }

            for (int i = 0; i <= 28; i++)
            {
                if (quyuoc[i] == a2) { M.n2 = i; }
            }

            return M;
             

           
        }

        public string number_to_anphalbet(Matrix2 C)
        {
            string chuoi_c;         
            string a1, a2;
            int k1 = (int)C.n1;
            int k2 = (int)C.n2;

            //if (k1 == 0)
            //{
            //    k1 = 26;
            //}
            //if (k2 == 0)
            //{
            //    k2 = 26;
            //}

            string[] quyuoc = {"A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"
            ,"P","Q","R","S","T","U","V","W","X","Y","Z","@","#","&"};

            a1 = quyuoc[k1];
            a2 = quyuoc[k2];
            chuoi_c = a1 + a2;
            return chuoi_c;

        }

        public Matrix2 matrix1_nhan_matrix2(Matrix K,Matrix2 M)
        {
            Matrix2 X = new Matrix2();
            X.n1 = K.m1 * M.n1 + K.m2 * M.n2;
            X.n2 = K.m3 * M.n1 + K.m4 * M.n2;

            return X;

        }
        public Matrix2 matrix2_cong_matrix2(Matrix2 M, Matrix2 V)
        {
            Matrix2 X = new Matrix2();
            X.n1 = M.n1+V.n1;
            X.n2 = M.n2+V.n2;
            return X;
        }

        public Matrix2 matrix2_tru_matrix2(Matrix2 C, Matrix2 V)
        {
            Matrix2 X = new Matrix2();
            X.n1 = C.n1 - V.n1;
            X.n2 = C.n2 - V.n2;
            return X;
        }

        public Matrix2 matrix2_mod_P(Matrix2 K, int P)
        {
            Matrix2 a = new Matrix2();
            a.n1 = Number_modP(K.n1, P);
            a.n2 = Number_modP(K.n2, P);


            return a;
        }

        public Matrix2 Mi_to_Ci(Matrix K, Matrix2 M, Matrix2 V,int P)
        {
            Matrix2 KM = new Matrix2();
            KM = matrix1_nhan_matrix2(K, M);
            KM = matrix2_cong_matrix2(KM, V);
            KM = matrix2_mod_P(KM, P);

            return KM;

        }

        public Matrix2 Ci_to_Mi(Matrix K, Matrix2 C, Matrix2 V, int P)
        {
            Matrix2 KC = new Matrix2();

            KC = matrix2_tru_matrix2(C, V);

            KC = matrix1_nhan_matrix2(K, KC);
            KC = matrix2_mod_P(KC, P);

            return KC;
            
        }

        public string mahoa(string banro1,Matrix K,Matrix2 V1,Matrix2 V2,int P)
        {

            
            string banro = banro1;
            int l = banro.Length;
          
            Matrix2 V = new Matrix2();
            Matrix2 matrix = new Matrix2();
          

            string banma = "";
            for(int i=1;i<=l/2;i++)
            {
                
                V = V2;
                string x1;
                string x2;
             
                x1 = banro.Substring(0, 1);
                x2 = banro.Substring(1, 1);

                if(banro.Length>2) { banro = cat_chuoi(banro); }
                matrix = anphalbet_to_number(x1, x2);
                if(i%2 ==1)
                {
                    V = V1;
                }
                matrix = Mi_to_Ci(K,matrix,V,P);
                banma = banma + number_to_anphalbet(matrix);

            }    


            return banma;
        }

        public string cat_chuoi(string chuoi)
        {

            string chuoi_moi = chuoi.Substring(2);

            return chuoi_moi;

        }

        public int leng(string chuoi)
        {
            return chuoi.Length;
        }

        public bool kt_du_lieu(string sdt)
        {
            if (sdt.Length != 10) return true;
            for (int i = 0; i < sdt.Length; ++i)
            {
                if (sdt[i] != '0' && sdt[i] != '1' && sdt[i] != '2' && sdt[i] != '3' && sdt[i] != '4'
                    && sdt[i] != '5' && sdt[i] != '6' && sdt[i] != '7' && sdt[i] != '8' && sdt[i] != '9')
                    return true;
            }
            return false;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///                    KIEM TRA DIEU KIEN 
        ///            

         public int matrixA_modunP_matrixG_logic(Matrix A , int P)
        {
            int a, b, dt_A;
            a = int.Parse(A.m1.ToString());
            b = int.Parse(A.m2.ToString());
            dt_A = int.Parse((A.m1 * A.m4 - A.m2 * A.m3).ToString());
            if (isPrimeNumber(P) == false)
            {
                return 0;
            }
            if (ucln(a, b) == false)
            {
                return 2;
            }
            if(ucln(dt_A,P)== false)
            {
                return 3;

            }
            if(KT_detGc() == false)
            {
                return 4;
            }


            return 0;
        }

        public  bool isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool matrixA_modunP_matrixG_dinhdang()
        {
             return true;
          

        }
        public bool kt_dinhdang_vanban()
        {
            return true;
        }
        /// 
        /// 
        /// 
        ///
        /// 
        private void btGiaiMaa_Click(object sender, EventArgs e)
        {
            // string banro = "JDHFJDAKDHSJDYEFRA";
            string s = txtBanRo2.Text.Trim().ToString();
            string banma = s;





            Matrix A = new Matrix();
            Matrix A_1 = new Matrix();
            Matrix G = new Matrix();
            Matrix G_1 = new Matrix();
            Matrix K_1 = new Matrix();
            Matrix2 V1 = new Matrix2();
            Matrix2 V2 = new Matrix2();
            Matrix P_A = new Matrix();
            Matrix P_G = new Matrix();
            int P;
            float det_A_nd;
            float det_G_nd;
            if (3 > 7)
            {
                MessageBox.Show("Lỗi văn bản");
            }
            else
            {
                if (5>8)
                {
                    MessageBox.Show("Lỗi dinh dạng P, A, G");
                }
                else
                {



                    //            switch (matrixA_modunP_matrixG_logic(A, P))
                    //            {
                    //                case 1:
                    //                    MessageBox.Show("P phải là số nguyên tố! ");
                    //                    break;
                    //                case 2:
                    //                    MessageBox.Show("Ma trận A phải là ma trận nguyên tố! ");
                    //                    break;
                    //                case 3:
                    //                    MessageBox.Show("P và det(A) phải nguyên tố cùng nhau!");
                    //                    break;
                    //                case 4:
                    //                    MessageBox.Show("det(G_c) phải có giá trị bằng 0 ");
                    //                    break;
                    //                case 0:
                    //                    P = Convert.ToInt32(txtP1.Text.ToString());

                    //                    A.m1 = float.Parse(txtA1.Text);
                    //                    A.m2 = float.Parse(txtA2.Text);
                    //                    A.m3 = float.Parse(txtA3.Text);
                    //                    A.m4 = float.Parse(txtA4.Text);

                    //                    G.m1 = float.Parse(txtG1.Text);
                    //                    G.m2 = float.Parse(txtG2.Text);
                    //                    G.m3 = float.Parse(txtG3.Text);
                    //                    G.m4 = float.Parse(txtG4.Text);


                    P = 29;

                    A.m1 = float.Parse(txtA5.Text);
                    A.m2 = float.Parse(txtA6.Text);
                    A.m3 = float.Parse(txtA7.Text);
                    A.m4 = float.Parse(txtA8.Text);

                    G.m1 = float.Parse(txtG5.Text);
                    G.m2 = float.Parse(txtG6.Text);
                    G.m3 = float.Parse(txtG7.Text);
                    G.m4 = float.Parse(txtG8.Text);
                    det_A_nd = Number_NghichDao(A, P);
                    det_G_nd = Number_NghichDao(G, P);



                    P_A.m1 = A.m4 * det_A_nd;
                    P_A.m2 = -A.m2 * det_A_nd;
                    P_A.m3 = -A.m3 * det_A_nd;
                    P_A.m4 = A.m1 * det_A_nd;

                    P_G.m1 = G.m4 * det_G_nd;
                    P_G.m2 = -G.m2 * det_G_nd;
                    P_G.m3 = -G.m3 * det_G_nd;
                    P_G.m4 = G.m1 * det_G_nd;


                    A_1 = matrix_mod_P(P_A, P);
                    G_1 = matrix_mod_P(P_G, P);

                    K_1 = A.Tich_mtr(G_1);
                    K_1 = K_1.Tich_mtr(A_1);
                    K_1 = matrix_mod_P(K_1, P);
                   
                    V1.n1 = A.m1;
                    V1.n2 = A.m2;

                    V2.n1 = A.m2;
                    V2.n2 = A.m1;

                                   //    MessageBox.Show(GiaiMa(banma, K_1, V1, V2, P));
                                   txtBanMa2.Text = GiaiMa(banma, K_1, V1, V2, P);









                    //                    break;

                    //            }
                    //       }

                }
            }
        }


        public string GiaiMa(string banro1, Matrix K, Matrix2 V1, Matrix2 V2, int P)
        {

            string banro = banro1;
            int l = banro.Length;

            Matrix2 V = new Matrix2();
            Matrix2 matrix = new Matrix2();


            string banma = "";
            for (int i = 1; i <= l / 2; i++)
            {

                V = V2;
                string x1;
                string x2;

                x1 = banro.Substring(0, 1);
                x2 = banro.Substring(1, 1);

                if (banro.Length > 2) { banro = cat_chuoi(banro); }
                matrix = anphalbet_to_number(x1, x2);
                if (i % 2 == 1)
                {
                    V = V1;
                }
                matrix = Ci_to_Mi(K, matrix, V, P);
                banma = banma + number_to_anphalbet(matrix);

            }





            return banma;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string banro = "FGENASNQZOCPEHZIJ#D#";
            //   string banro = "ADQFAOKSOKSH";
            int P = 29;

            Matrix K = new Matrix(13, 12, 5, 28);


            Matrix2 V1 = new Matrix2(3, 4);
            Matrix2 V2 = new Matrix2(4, 3);

            MessageBox.Show(GiaiMa(banro, K, V1, V2, P));
        }

        private void btImport2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                txtBanRo2.Text = read.ReadToEnd();
                read.Close();

            }
        }

        private void btRandomKey_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("gia tr cua K la : " + random_A().m1.ToString() + "a" + random_A().m2.ToString() + "a"
            //    + random_A().m3.ToString() + "a" + random_A().m4.ToString() + "a");
            txtA1.Text = random_A().m1.ToString();
            txtA2.Text = random_A().m2.ToString();
            txtA3.Text = random_A().m3.ToString();
            txtA4.Text = random_A().m4.ToString();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //
        //public string mahoa(string banro1)
        //{


        //    string banro = banro1;
        //    int l = banro.Length;
        //    Matrix K = new Matrix(2, 24, 10, 3);
        //    //  Matrix2 M = new Matrix2(1,4);

        //    Matrix2 V1 = new Matrix2(3, 4);
        //    Matrix2 V2 = new Matrix2(4, 3);
        //    Matrix2 V = new Matrix2();
        //    Matrix2 matrix = new Matrix2();
        //    int P = 29;

        //    string banma = "";
        //    for (int i = 1; i <= l / 2; i++)
        //    {

        //        V = V2;
        //        string x1;
        //        string x2;

        //        x1 = banro.Substring(0, 1);
        //        x2 = banro.Substring(1, 1);

        //        if (banro.Length > 2) { banro = cat_chuoi(banro); }
        //        matrix = anphalbet_to_number(x1, x2);
        //        if (i % 2 == 1)
        //        {
        //            V = V1;
        //        }
        //        matrix = Mi_to_Ci(K, matrix, V, P);
        //        banma = banma + number_to_anphalbet(matrix);

        //    }


        //    return banma;
        public float KK(float det , int P)
        {



            float dinhthuc_A = det;

            if (dinhthuc_A > 0)
            {
                for (int i = 1; i < 999999999; i=i+2)
                {
                    if ((dinhthuc_A * i) % P == 1)
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = 1; i < 99999; i++)
                {
                    if ((-dinhthuc_A * i) % P == 1)
                    {
                        return -i;
                    }
                }

            }



            return 0;



        }
    }
    

   






}



