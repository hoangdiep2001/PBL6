using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL6.BLL
{
    public class BLL
    {
        PBL6Entities db = new PBL6Entities();
        private static BLL _Instance;
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL()
        {

        }
        public bool CheckAccount(string Name, string pass)
        {
            foreach (User i in db.User)
            {
                if (i.Username == Name && i.Password == pass)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddAccount(User s)
        {
            db.User.Add(s);
            db.SaveChanges();
        }
        public void UpdatePass(User s)
        {
            User k = db.User.Find(s.IDAccount);
            k.Password = s.Password;
            db.SaveChanges();
        }
        public bool CheckDup(string Name)
        {
            foreach (User i in db.User)
            {
                if (i.Username == Name)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddMahoa(Mahoa s)
        {
            db.Mahoa.Add(s);
            db.SaveChanges();
        }
        public void DelMahoa(string IDMH)
        {
            Mahoa s = db.Mahoa.Find(IDMH);
            db.Mahoa.Remove(s);
            db.SaveChanges();
        }
        public void AddGiaima(GiaiMa s)
        {
            db.GiaiMa.Add(s);

            db.SaveChanges();
        }
        public void DelGiaiMa(string IDGM)
        {
            GiaiMa s = db.GiaiMa.Find(IDGM);
            db.GiaiMa.Remove(s);
            db.SaveChanges();
        }
        public List<Mahoa> GetAllMahoa()
        {
            List<Mahoa> s = new List<Mahoa>();
            s = db.Mahoa.ToList();
            return s;
        }
        public List<GiaiMa> GetAllGiaima()
        {
            List<GiaiMa> s = new List<GiaiMa>();
            s = db.GiaiMa.ToList();
            return s;
        }
        public List<GiaiMa> GetGiaimaByKeyA(string KeyA)
        {
            List<GiaiMa> s = new List<GiaiMa>();
            s = db.GiaiMa.Where(p => (p.KeyA == KeyA)).ToList();
            return s;
        }
        public List<Mahoa> GetMahoaByKeyA(string KeyA)
        {
            List<Mahoa> s = db.Mahoa.Where(p => (p.KeyA == KeyA)).ToList();
            return s;
        }
        public List<GiaiMa> GetGiaimaByKeyG(string KeyG)
        {
            List<GiaiMa> s = new List<GiaiMa>();
            s = db.GiaiMa.Where(p => (p.KeyG == KeyG)).ToList();
            return s;
        }
        public List<Mahoa> GetMahoaByKeyG(string KeyG)
        {
            List<Mahoa> s = db.Mahoa.Where(p => (p.KeyG == KeyG)).ToList();
            return s;
        }
    }
}
