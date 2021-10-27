using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; // para usar el archivo XML App.config
                            // donde hemos guardado la cadena de 
                            // conexión





namespace spotify
{
    public class GestorDeBaseDeDatos
    {
        private static GestorDeBaseDeDatos instance = null;

        private string myConnectionString;
        private SqlConnection myConnection;
        private SqlCommand mySelectCommand;
        private SqlCommand myCommand;
        private SqlDataAdapter myDataAdapter;

        public SqlConnection MyConnection
        {
            get { return myConnection; }
        }
        public string MyConnectionString
        {
            get { return myConnectionString; }
            set { myConnectionString = value; }
        }

        public GestorDeBaseDeDatos()
        {


            myConnectionString = ConfigurationManager.AppSettings.Get("MiCadenaDeConexion");
            Console.WriteLine(myConnectionString);
            myConnection = new SqlConnection(myConnectionString);
            
        }

        public static GestorDeBaseDeDatos Instance
        {
            get
            {
                if (instance == null)
                    instance = new GestorDeBaseDeDatos();
                return instance;
            }
        }

        public DataSet EjecutarConsultaSelect(string selectQuery)
        {
            DataSet myDataSet = new DataSet();
            try
            {
                myConnection.Open();
                mySelectCommand = new SqlCommand(selectQuery, myConnection);
                myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = mySelectCommand;
                myDataAdapter.Fill(myDataSet);
                if (myDataSet != null)
                {
                    if (myDataSet.Tables.Count != 0)
                    {
                        if (myDataSet.Tables[0].Rows.Count != 0)
                        {
                            return myDataSet;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return myDataSet;
                }
            }
            catch (Exception)
            {
                return null;
            }

            finally
            {
                if (myConnection.State != ConnectionState.Closed)
                    myConnection.Close();
            }
        }


        public int EjecutarConsulta(string query)
        {
            int registrosAfectados = 0;
            try
            {
                
                myConnection.Open();
                myCommand = new SqlCommand(query, myConnection);
                registrosAfectados = myCommand.ExecuteNonQuery();
                return registrosAfectados;
           }
            catch (Exception)
            {
                
                
                return registrosAfectados;
            }
            finally
            {
                if (myConnection.State != ConnectionState.Closed)
                    myConnection.Close();
            }
           
        }

        /********************************************
         *  lo nuevo
         *  *****************************************/
        
        /*public void actualizarBD()
        {
            DataSet myDataSet = new DataSet();
            try
            {
                myConnection.Open();
                myDataAdapter = new TableLayoutPanel()
                mySelectCommand = new SqlCommand(selectQuery, myConnection);
                myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = mySelectCommand;
                myDataAdapter.Fill(myDataSet);
                if (myDataSet != null)
                {
                    if (myDataSet.Tables.Count != 0)
                    {
                        if (myDataSet.Tables[0].Rows.Count != 0)
                        {
                            return myDataSet;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return myDataSet;
                }
            }
            catch (Exception)
            {
                return null;
            }

            finally
            {
                if (myConnection.State != ConnectionState.Closed)
                    myConnection.Close();
            }
        }
        */

    }
}
