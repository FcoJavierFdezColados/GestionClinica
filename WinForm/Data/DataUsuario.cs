using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Data
{
    public class DataUsuario
    {
        public static DataUsuario instance;

        public static DataUsuario GetInstance()
        {
            if (instance == null)
                instance = new DataUsuario();

            return instance;
        }

        public List<Modelo.Usuario> ListarUsuarios()
        {
            using (var context = new Modelo.GestionClinicaContextSqlServer())
            {
                return context.Usuarios.ToList();
            }
        }

        public void InsertarUsuario(Modelo.Usuario usuario)
        {
            try
            {
                using (var context = new Modelo.GestionClinicaContextSqlServer())
                {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        public void ActualizarUsuario(int usuarioId, Modelo.Usuario usuario)
        {
            try
            {
                using (var context = new Modelo.GestionClinicaContextSqlServer())
                {
                    var usuarioData = context.Usuarios.FirstOrDefault(x => x.UsuarioId == usuarioId);

                    if (usuarioData != null)
                    {
                        context.Entry(usuarioData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        context.Entry(usuarioData).CurrentValues.SetValues(usuario);
                        context.SaveChanges();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        //public void BloquearUsuario(int usuarioId)
        //{
        //    try
        //    {
        //        using (var context = new Modelo.GestionClinicaContextSqlServer())
        //        {
        //            var usuarioData = context.Usuarios.FirstOrDefault(x => x.UsuarioId == usuarioId);

        //            if (usuarioData != null)
        //            {
        //                context.Entry(usuarioData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //                context.SaveChanges();
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.Error.WriteLine(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Error.WriteLine(ex.StackTrace);
        //    }
        //}
    }
}
