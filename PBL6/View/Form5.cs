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
            txtP1.Text = "";
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
            
            if (txtA1.Text.Trim()=="" || txtA2.Text.Trim() == "" || txtA3.Text.Trim() == "" || txtA4.Text.Trim() == ""
                || txtG1.Text.Trim() == ""|| txtG2.Text.Trim() == ""|| txtG3.Text.Trim() == ""|| txtG4.Text.Trim() == ""
                || txtP1.Text.Trim() == "")
            {
                MessageBox.Show(" thong tin khoa P,A,G còn thiếu !!!");


            }   
            
            else
            {
                Matrix X = new Matrix();
                Matrix A = new Matrix();
                Matrix B = new Matrix();

                A.m1 = float.Parse(txtA1.Text);
                A.m2 = float.Parse(txtA2.Text);
                A.m3 = float.Parse(txtA3.Text);
                A.m4 = float.Parse(txtA4.Text);


                B.m1 = float.Parse(txtG1.Text);
                B.m2 = float.Parse(txtG2.Text);
                B.m3 = float.Parse(txtG3.Text);
                B.m4 = float.Parse(txtG4.Text);

                MessageBox.Show(" gia tri khi nhan 2 ma tran la " + A.Tich_mtr(B).m1.ToString()+"a" + A.Tich_mtr( B).m2.ToString() + "a"
                    + A.Tich_mtr(B).m3.ToString() + "a"
                    + A.Tich_mtr( B).m4.ToString() + "a");
                

            }    

        }

        private void btMatrixNd_Click(object sender, EventArgs e)
        {
           
            Matrix A = new Matrix();
            Matrix P_A = new Matrix();
            int P = Convert.ToInt32(txtP1.Text);

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

            MessageBox.Show("dinh thuc ma tran G_c la " + KT_detGc());




            //Matrix A = new Matrix();
            //Matrix A_nd = new Matrix();
            //Matrix B = new Matrix();
            //Matrix AB = new Matrix();
            //Matrix K = new Matrix();
            //A.m1 = float.Parse(txtA1.Text);
            //A.m2 = float.Parse(txtA2.Text);
            //A.m3 = float.Parse(txtA3.Text);
            //A.m4 = float.Parse(txtA4.Text);


            //B.m1 = float.Parse(txtG1.Text);
            //B.m2 = float.Parse(txtG2.Text);
            //B.m3 = float.Parse(txtG3.Text);
            //B.m4 = float.Parse(txtG4.Text);

            //A_nd = A.matrixDN();
            //AB = A.Tich_mtr(B);
            //K = AB.Tich_mtr(A_nd);
            //K = K.matrix_modP(Convert.ToInt32(txtP1.Text));

            //MessageBox.Show("gia tri la " + K.m1.ToString() + "a" + K.m2.ToString() + "a" + K.m3.ToString() +
            //    "a" + K.m4.ToString() + "a");
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {

            //txtA1.Text = random_A().m1.ToString();
            //txtA2.Text = random_A().m2.ToString();
            //txtA3.Text = random_A().m3.ToString();
            //txtA4.Text = random_A().m4.ToString();

            Matrix A = new Matrix();
            Matrix G = new Matrix();
            A.m1 = float.Parse(txtA1.Text);
            A.m2 = float.Parse(txtA2.Text);
            A.m3 = float.Parse(txtA3.Text);
            A.m4 = float.Parse(txtA4.Text);

            //G.m1 = float.Parse(txtG1.Text);
            //G.m2 = float.Parse(txtG2.Text);
            //G.m3 = float.Parse(txtG3.Text);
            //G.m4 = float.Parse(txtG4.Text);

            int p1 = Convert.ToInt32(txtP1.Text.ToString());
            float DinhThuc_A = A.m1 * A.m4 - A.m2 * A.m3;
            int DinhThuc_A_int = Convert.ToInt32(DinhThuc_A);

            if(ucln(p1,DinhThuc_A_int) ==false)
            {
                MessageBox.Show("định thức ma trận A và P ko nguyên tố cùng nhau , chọn lại P !!");

            }

            else
            {
                //if(-p1>DinhThuc_A_int ||DinhThuc_A_int>p1)
                //{
                //    MessageBox.Show(" Lỗi  (-P > DinhThuc_A_int) || (DinhThuc_A_int > P)");
                //}
                //else
                //{
                //    MessageBox.Show(" Hợp lệ  (-P<= DinhThuc_A_int <= P) ");
                //}
            }
            }






        

        public bool kt_ThieuthongTin()
        {
            if ((txtA1.Text.Trim() == "") || (txtA2.Text.Trim() == "") || (txtA3.Text.Trim() == "") ||
                (txtA4.Text.Trim() == "") || (txtG1.Text.Trim() == "") || (txtG2.Text.Trim() == "") ||
                (txtG3.Text.Trim() == "") || (txtG4.Text.Trim() == "") || (txtP1.Text.Trim() == "")

                )
                return false;
            else return true;
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
      

            do
            {
                a = rand.Next(1, 100);
                b = rand.Next(1, 100);

                A.m1 = a;
                A.m2 = b;
                A.m3 = b;
                A.m4 = a;


            }

            while (ucln(a, b) == false
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
            //float dinhthuc_nd = 0;
            //float x;
            //float i = 0;
            //float dinhthuc_A = A.m1 * A.m4 - A.m3 * A.m2;

            //do
            //{
            //    x = i + 1;

            //}
            //while ((((-dinhthuc_A * x) % P) != 1)  );

            //return x;



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
             string banro = "ADDIDAIK";
            //Matrix K = new Matrix(2, 24, 10, 3);
            //Matrix2 M = new Matrix2(1, 4);
            //Matrix2 V = new Matrix2(3, 4);         
            //Matrix2 matrix = new Matrix2();
            //int P = 29;

            //matrix.n1= Mi_to_Ci(K, M, V, P).n1;
            //matrix.n2 = Mi_to_Ci(K, M, V, P).n2;



            MessageBox.Show(mahoa(banro));
        }


        public Matrix2 anphalbet_to_number(string a1, string a2)
        {
            Matrix2 M = new Matrix2();
           
            string[] quyuoc = {"0","A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"
            ,"P","Q","R","S","T","U","V","W","X","Y","Z"};

            for(int i=1;i<=26;i++)
            {
                if(quyuoc[i] == a1) { M.n1 = i; }
            }

            for (int i = 1; i <= 26; i++)
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

            string[] quyuoc = {"0","A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"
            ,"P","Q","R","S","T","U","V","W","X","Y","Z"};

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

        public string mahoa(string banro1)
        {

            
            string banro = banro1;
            int l = banro.Length;
            Matrix K = new Matrix(2,24,10,3);
            Matrix2 M = new Matrix2(1,4);

            Matrix2 V1 = new Matrix2(3,4);
            Matrix2 V2 = new Matrix2(4, 3);
            Matrix2 V = new Matrix2();
            Matrix2 matrix = new Matrix2();
            int P = 29;

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


    }







}



