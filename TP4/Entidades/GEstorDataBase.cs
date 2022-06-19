using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void Actualizador(DataTable datos);
    public delegate void Informador(string excepciones);
    public class GEstorDataBase
    {
        private SqlConnection sqlConexion;
        private Thread hilo;
        public event Actualizador EventoActualizarDataBase;
        public event Informador EventoInformarDataBase;
        private SqlCommand sqlCommand;
        private string servidor;
        private string usuario;
        private string password;
        private string dataBase;

        public GEstorDataBase(string servidor, string dataBase, string usuario, string password)
        {
            this.servidor = servidor;
            this.dataBase = dataBase;
            this.usuario = usuario;
            this.password = password;
            this.sqlConexion = new SqlConnection($"Server={this.servidor}; DataBase={this.dataBase}; User Id ={this.usuario}; Password={this.password}; Connect TimeOut=600");
            this.hilo = new Thread(LeerRegistros);

        }

        public string Sentencia
        {
            set
            {
                string strAux = value.ToLower();
                if(!strAux.Contains("delete") && !strAux.Contains("inserd"))
                {
                    this.sqlCommand = new SqlCommand(value, this.sqlConexion);
                }
                else
                {
                    throw new Exception("No se puede ejecutar la sentencia indicada");
                }

            }
        }

        public bool Activar
        {
            get
            {
                bool retorno = false;
                if(!object.ReferenceEquals(this.hilo, null))
                {
                    retorno = this.hilo.IsAlive;
                }
                return retorno;
            }
            set
            {
                if(value && !object.ReferenceEquals(this.hilo, null) && !this.hilo.IsAlive)
                {
                    if(this.hilo.ThreadState == ThreadState.Aborted || this.hilo.ThreadState == ThreadState.Stopped)
                    {
                        this.hilo = new Thread(LeerRegistros);
                    }
                }
                else if(!object.ReferenceEquals(this.hilo, null) && !value)
                {
                    this.hilo.Abort();
                }
            }
        }

        private void LeerRegistros()
        {
            try
            {
                this.EventoActualizarDataBase.Invoke(this.LeerDesdeDB());
            }
            catch(Exception ex)
            {
                this.EventoInformarDataBase.Invoke(ex.Message);
            }
        }
        private DataTable LeerDesdeDB()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                sqlDataAdapter.Fill(dataTable);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(this.sqlConexion != null && this.sqlConexion.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConexion.Close();
                }
            }
            return dataTable;
        }

    }
}
