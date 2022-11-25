﻿using CapaDeEntidad.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos.Clases
{
    public class CD_DetalleServicio
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_DetalleServicio ce = new CE_DetalleServicio();

        #region Insertar
        public void CD_Insertar(CE_DetalleServicio Servicios)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "dbo.SP_DS_Insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.Add("@fecha", SqlDbType.Date).Value = Servicios.Fecha;
            com.Parameters.AddWithValue("@montoTotal", Servicios.MontoTotal);
            com.Parameters.AddWithValue("@idServicio", Servicios.IdServicio);
            com.Parameters.AddWithValue("@idUsuario", Servicios.IdUsuario);
            com.Parameters.AddWithValue("@idReserva", Servicios.IdReserva);

            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region CARGAR 

        public DataTable VerServiciosContratados(int idUsuario, int idReserva)
        {
            SqlDataAdapter da = new SqlDataAdapter("dbo.SP_DS_VerContratados", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
            da.SelectCommand.Parameters.Add("@idReserva", SqlDbType.Int).Value = idReserva;

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion
    }
}