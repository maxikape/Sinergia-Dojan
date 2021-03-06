using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SinergiaApp
{
    class SinergiaDB
    {
        private string connectionString = "Data Source= DESKTOP-P9QCAB9;Initial Catalog= SinergiaDB;Integrated Security = True";

        public bool Ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
            }
            catch
            {
                return false;
            }

            return true;

        }

        public List<Alumnos> Get()
        {
            List<Alumnos> alumnos = new List<Alumnos>();

            string query = "Select * from alumnos ORDER BY Apellido";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, connection);


                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {

                        Alumnos Oalumnos = new Alumnos();
                        Oalumnos.Id = reader.GetInt32(0);
                        Oalumnos.Nombre = reader.GetString(1);
                        Oalumnos.Apellido = reader.GetString(2);
                        Oalumnos.Dni = reader.GetString(3);
                        Oalumnos.Direccion = reader.GetString(4);
                        Oalumnos.Telefono = reader.GetString(5);
                        Oalumnos.FechaIngreso = reader.GetString(6);
                        Oalumnos.Estado = reader.GetInt32(7);
                        Oalumnos.Asistencias = reader.GetInt32(8);
                        Oalumnos.Pago = reader.GetInt32(9);
                        Oalumnos.NumeroAlumno = reader.GetInt32(10);
                        //Oalumnos.Foto = reader.GetInt32(11);
                        Oalumnos.FichaMedica = reader.GetInt32(12);
                        Oalumnos.Carnet = reader.GetInt32(11);




                        alumnos.Add(Oalumnos);

                    }
                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {

                    throw new Exception("hay un error en la base de datos" + ex.Message);
                }

            }

            return alumnos;
        }

        public void Add(string Nombre, string Apellido, string Dni, string Direccion, string Telefono, string FechaIngreso, int Estado, int Asistencias, int Pago, int NumeroAlumno, byte[] Foto, int FichaMedica, int Carnet)
        {
            string query = "INSERT INTO Alumnos(Nombre, Apellido, Dni, Direccion, Telefono, FechaIngreso, Estado, Asistencias, Pago,NumeroAlumno, Foto, FichaMedica, Carnet) values " +
                "(@Nombre, @Apellido, @Dni, @Direccion, @Telefono, @FechaIngreso, @Estado, @Asistencias, @Pago, @NumeroAlumno, @Foto, @FichaMedica, @Carnet)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Dni", Dni);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@Asistencias", Asistencias);
                comando.Parameters.AddWithValue("@Pago", Pago);
                comando.Parameters.AddWithValue("@NumeroAlumno", NumeroAlumno);
                comando.Parameters.AddWithValue("@Foto", Foto);
                comando.Parameters.AddWithValue("@FichaMedica", FichaMedica);
                comando.Parameters.AddWithValue("@Carnet", Carnet);


                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();

                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la base de datos" + ex.Message);
                }

            }


        }


        public void Edit(string Nombre, string Apellido, string Dni, string Direccion, string Telefono, int Estado, int Asistencias, int Id, int Pago, int NumeroAlumno, int FichaMedica, int Carnet)
        {
            string query = "UPDATE Alumnos SET Nombre = @Nombre , Apellido=@Apellido, Dni = @Dni, Direccion= @Direccion," +
                "Telefono=@Telefono, Estado= @Estado, Asistencias = @Asistencias , Pago = @Pago ,  NumeroAlumno = NumeroAlumno, FichaMedica = @FichaMedica, Carnet = @Carnet " +
                "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);
                comando.Parameters.AddWithValue("@Dni", Dni);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Telefono", Telefono);

                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@Asistencias", Asistencias);
                comando.Parameters.AddWithValue("@Id", Id);
                comando.Parameters.AddWithValue("@Pago", Pago);
                comando.Parameters.AddWithValue("@NumeroAlumno", @NumeroAlumno);
                comando.Parameters.AddWithValue("@FichaMedica", FichaMedica);
                comando.Parameters.AddWithValue("@Carnet", Carnet);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();

                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la base de datos" + ex.Message);
                }

            }


        }



        //trae el alumno para ser modificado

        public Alumnos RecuperarAlumno(int CodigoAlumno)
        {


            string query = "Select * from alumnos" +
                " WHERE NumeroAlumno = @NumeroAlumno";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@NumeroAlumno", CodigoAlumno);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Alumnos Oalumnos = new Alumnos();
                    Oalumnos.Id = reader.GetInt32(0);
                    Oalumnos.Nombre = reader.GetString(1);
                    Oalumnos.Apellido = reader.GetString(2);
                    Oalumnos.Dni = reader.GetString(3);
                    Oalumnos.Direccion = reader.GetString(4);
                    Oalumnos.Telefono = reader.GetString(5);
                    //Oalumnos.FechaIngreso = reader.GetString(6);
                    Oalumnos.Estado = reader.GetInt32(7);
                    Oalumnos.Asistencias = reader.GetInt32(8);

                    Oalumnos.Pago = reader.GetInt32(9);
                    Oalumnos.NumeroAlumno = reader.GetInt32(10);
                    //Oalumnos.Foto = reader.GetByte(11);




                    reader.Close();
                    connection.Close();

                    return Oalumnos;


                }
                catch (Exception ex)
                {

                    throw new Exception("hay un error en la base de datos" + ex.Message);
                }

            }


        }

        public void SumarAsistencia(int Id, int Asistencias)
        {
            string query = "UPDATE Alumnos SET Asistencias = @Asistencias " +
                "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(query, connection);


                comando.Parameters.AddWithValue("@Asistencias", Asistencias);
                comando.Parameters.AddWithValue("@Id", Id);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();

                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la base de datos" + ex.Message);
                }

            }


        }

        //public void FiltrarAlumnos(String apellido)
        //{
        //    //int IDD = Convert.ToInt32(CodigoAlumno);

        //    string query = "Select * from alumnos" +
        //        " WHERE Apellido like('" + apellido + "%')";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlCommand comando = connection.CreateCommand();
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText =query;

        //        DataTable dt = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(comando);

        //        var a = da.Fill(dt);



        //    }
        //}
    }


}

