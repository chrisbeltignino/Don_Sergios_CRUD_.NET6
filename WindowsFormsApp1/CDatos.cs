using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class CDatos
    {
        DBDON_SERGIOSEntities db;

        //#region CLIENTES
        public void Create(CLIENTES cCliente) 
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.CLIENTES.Add(cCliente);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<CLIENTES> Read()
        {
            try
            {
                using(db=new DBDON_SERGIOSEntities())
                {
                    return db.CLIENTES.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(CLIENTES cCliente)
        {
            try
            {
                using(db=new DBDON_SERGIOSEntities())
                {
                    db.Entry(cCliente).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void Delete(int cID)
        {
            try
            {
                using(db=new DBDON_SERGIOSEntities())
                {
                    db.CLIENTES.Remove(db.CLIENTES.Single(c => c.ID == cID));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<CLIENTES> buscarTelefono(string cTelefono)
        {
            try
            {
                using(db = new DBDON_SERGIOSEntities())
                {
                    return db.CLIENTES.Where(c => c.TELEFONO == cTelefono).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<CLIENTES> buscarNombre(string cNombre)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    return db.CLIENTES
                        .Include(c => c.AUTOS)
                        .Include(c => c.SERVICIOS)
                        .Where(c => c.NOMBRES.Contains(cNombre))
                        .ToList();
                       }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //#endregion

        public void CreateAuto(AUTOS aAutos)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.AUTOS.Add(aAutos);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<AUTOS> ReadAuto()
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    return db.AUTOS.Include(a => a.MODELOS).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void UpdateAuto(AUTOS aAutos)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.Entry(aAutos).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteAuto(int aID)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.AUTOS.Remove(db.AUTOS.Single(a => a.ID_AUTO == aID));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<MODELOS> ReadModelo()
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    return db.MODELOS.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void CreateServicio(SERVICIOS sServicio)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.SERVICIOS.Add(sServicio);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<SERVICIOS> ReadServicio()
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    return db.SERVICIOS.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void UpdateServicio(SERVICIOS sServicio)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.Entry(sServicio).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteServicio(int sID)
        {
            try
            {
                using (db = new DBDON_SERGIOSEntities())
                {
                    db.SERVICIOS.Remove(db.SERVICIOS.Single(s => s.ID_SERVICIO == sID));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
