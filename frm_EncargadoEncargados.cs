using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patitasOrgMILAV
{
    //SQLHENV hEnv;
    //SQLHDBC hDbc;
    //SQLHSTMT hStmt;
    //SQLRETURN ret;
    public partial class frm_EncargadoEncargados : Form
    {
        public frm_EncargadoEncargados()
        {
            InitializeComponent();
        }

        private void btnBuscarAE_Click(object sender, EventArgs e)
        {
            SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &hEnv);
            SQLSetEnvAttr(hEnv, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0);

            // Conecta a la base de datos
            SQLAllocHandle(SQL_HANDLE_DBC, hEnv, &hDbc);
            ret = SQLDriverConnect(hDbc, NULL, (SQLCHAR*)"DRIVER={SQL Server};SERVER=mi_servidor;DATABASE=mi_base_de_datos;UID=mi_usuario;PWD=mi_contraseña;", SQL_NTS, NULL, 0, NULL, SQL_DRIVER_COMPLETE);

            if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
            {
                std::cout << "Conexión exitosa a la base de datos." << std::endl;

                // Prepara la consulta SQL para buscar datos
                SQLAllocHandle(SQL_HANDLE_STMT, hDbc, &hStmt);
                const char* sql = "SELECT columna1, columna2 FROM mi_tabla WHERE columna1 = ?;";
                SQLPrepare(hStmt, (SQLCHAR*)sql, SQL_NTS);

                // Establece el valor para el parámetro
                const char* valor1 = "valor1"; // Cambia esto al valor que deseas buscar
                SQLBindParameter(hStmt, 1, SQL_PARAM_INPUT, SQL_C_CHAR, SQL_CHAR, 0, 0, (SQLPOINTER)valor1, 0, NULL);

                // Ejecuta la consulta
                ret = SQLExecute(hStmt);
                if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
                {
                    // Procesa los resultados
                    while (SQLFetch(hStmt) == SQL_SUCCESS)
                    {
                        char columna1[256];
                        char columna2[256];

                        // Obtiene los valores de las columnas
                        SQLGetData(hStmt, 1, SQL_C_CHAR, columna1, sizeof(columna1), NULL);
                        SQLGetData(hStmt, 2, SQL_C_CHAR, columna2, sizeof(columna2), Null);

                        // Muestra los resultados
                        std::cout << "Columna1: " << columna1 << ", Columna2: " << columna2 << std::endl;
                    }
                }
                else
                {
                    std::cerr << "Error al ejecutar la consulta." << std::endl;
                }

                // Libera los recursos
                SQLFreeHandle(SQL_HANDLE_STMT, hStmt);
            }
            else
            {
                std::cerr << "Error al conectar a la base de datos." << std::endl;
            }

            // Cierra la conexión y libera el entorno
            SQLDisconnect(hDbc);
            SQLFreeHandle(SQL_HANDLE_DBC, hDbc);
            SQLFreeHandle(SQL_HANDLE_ENV, hEnv);
            return 0;
        }

        private void btnGuardarAE_Click(object sender, EventArgs e)
        {
            SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &hEnv);
            SQLSetEnvAttr(hEnv, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0);

            // Conecta a la base de datos TDengine
            SQLAllocHandle(SQL_HANDLE_DBC, hEnv, &hDbc);
            ret = SQLDriverConnect(hDbc, NULL, (SQLCHAR*)"DRIVER={TDengine};SERVER=mi_servidor;UID=mi_usuario;PWD=mi_contraseña;DATABASE=mi_base_de_datos;", SQL_NTS, NULL, 0, NULL, SQL_DRIVER_COMPLETE);

            if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
            {
                std::cout << "Conexión exitosa a la base de datos TDengine." << std::endl;

                // Prepara la consulta SQL para insertar datos
                SQLAllocHandle(SQL_HANDLE_STMT, hDbc, &hStmt);
                const char* sql = "INSERT INTO mi_tabla (columna1, columna2) VALUES (?, ?);";
                SQLPrepare(hStmt, (SQLCHAR*)sql, SQL_NTS);

                // Establece los valores para los parámetros
                const char* valor1 = "valor1"; // Cambia esto al valor que deseas insertar
                const char* valor2 = "valor2"; // Cambia esto al valor que deseas insertar
                SQLBindParameter(hStmt, 1, SQL_PARAM_INPUT, SQL_C_CHAR, SQL_CHAR, 0, 0, (SQLPOINTER)valor1, 0, NULL);
                SQLBindParameter(hStmt, 2, SQL_PARAM_INPUT, SQL_C_CHAR, SQL_CHAR, 0, 0, (SQLPOINTER)valor2, 0, NULL);

                // Ejecuta la consulta
                ret = SQLExecute(hStmt);
                if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
                {
                    std::cout << "Datos insertados correctamente." << std::endl;
                }
                else
                {
                    std::cerr << "Error al insertar datos." << std::endl;
                }

                // Libera los recursos
                SQLFreeHandle(SQL_HANDLE_STMT, hStmt);
            }
            else
            {
                std::cerr << "Error al conectar a la base de datos TDengine." << std::endl;
            }

            // Cierra la conexión y libera el entorno
            SQLDisconnect(hDbc);
            SQLFreeHandle(SQL_HANDLE_DBC, hDbc);
            SQLFreeHandle(SQL_HANDLE_ENV, hEnv);
            return 0;
        }

        private void btnEliminarEE_Click(object sender, EventArgs e)
        {
            SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &hEnv);
            SQLSetEnvAttr(hEnv, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0);

            // Conecta a la base de datos
            SQLAllocHandle(SQL_HANDLE_DBC, hEnv, &hDbc);
            ret = SQLDriverConnect(hDbc, NULL, (SQLCHAR*)"DRIVER={SQL Server};SERVER=mi_servidor;DATABASE=mi_base_de_datos;UID=mi_usuario;PWD=mi_contraseña;", SQL_NTS, NULL, 0, NULL, SQL_DRIVER_COMPLETE);

            if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
            {
                std::cout << "Conexión exitosa a la base de datos." << std::endl;

                // Prepara la consulta SQL para eliminar datos
                SQLAllocHandle(SQL_HANDLE_STMT, hDbc, &hStmt);
                const char* sql = "DELETE FROM mi_tabla WHERE columna1 = ?;";
                SQLPrepare(hStmt, (SQLCHAR*)sql, SQL_NTS);

                // Establece el valor para el parámetro
                const char* valor1 = "valor1"; // Cambia esto al valor que deseas eliminar
                SQLBindParameter(hStmt, 1, SQL_PARAM_INPUT, SQL_C_CHAR, SQL_CHAR, 0, 0, (SQLPOINTER)valor1, 0, NULL);

                // Ejecuta la consulta
                ret = SQLExecute(hStmt);
                if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
                {
                    std::cout << "Datos eliminados correctamente." << std::endl;
                }
                else
                {
                    std::cerr << "Error al eliminar datos." << std::endl;
                }

                // Libera los recursos
                SQLFreeHandle(SQL_HANDLE_STMT, hStmt);
            }
            else
            {
                std::cerr << "Error al conectar a la base de datos." << std::endl;
            }

            // Cierra la conexión y libera el entorno
            SQLDisconnect(hDbc);
            SQLFreeHandle(SQL_HANDLE_DBC, hDbc);
            SQLFreeHandle(SQL_HANDLE_ENV, hEnv);
            return 0;
        }

        private void btnRE_Click(object sender, EventArgs e)
        {
            // Inicializa el entorno ODBC
            SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &hEnv);
            SQLSetEnvAttr(hEnv, SQL_ATTR_ODBC_VERSION, (SQLPOINTER)SQL_OV_ODBC3, 0);

            // Conecta a la base de datos
            SQLAllocHandle(SQL_HANDLE_DBC, hEnv, &hDbc);
            ret = SQLDriverConnect(hDbc, NULL, (SQLCHAR*)"DRIVER={SQL Server};SERVER=mi_servidor;DATABASE=mi_base_de_datos;UID=mi_usuario;PWD=mi_contraseña;", SQL_NTS, NULL, 0, NULL, SQL_DRIVER_COMPLETE);

            if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
            {
                std::cout << "Conexión exitosa a la base de datos." << std::endl;

                // Prepara la consulta SQL para insertar datos
                SQLAllocHandle(SQL_HANDLE_STMT, hDbc, &hStmt);
                const char* sql = "INSERT INTO mi_tabla (columna1, columna2) VALUES (?, ?);";
                SQLPrepare(hStmt, (SQLCHAR*)sql, SQL_NTS);

                // Establece los valores para los parámetros
                const char* valor1 = "valor1";
                const char* valor2 = "valor2";
                SQLBindParameter(hStmt, 1, SQL_PARAM_INPUT, SQL_C_CHAR, SQL_CHAR, 0, 0, (SQLPOINTER)valor1, 0, NULL);
                SQLBindParameter(hStmt, 2, SQL_PARAM_INPUT, SQL_C_CHAR, SQL_CHAR, 0, 0, (SQLPOINTER)valor2, 0, NULL);

                // Ejecuta la consulta
                ret = SQLExecute(hStmt);
                if (ret == SQL_SUCCESS || ret == SQL_SUCCESS_WITH_INFO)
                {
                    std::cout << "Datos insertados correctamente." << std::endl;
                }
                else
                {
                    std::cerr << "Error al insertar datos." << std::endl;
                }

                // Libera los recursos
                SQLFreeHandle(SQL_HANDLE_STMT, hStmt);
            }
            else
            {
                std::cerr << "Error al conectar a la base de datos." << std::endl;
            }

            // Cierra la conexión y libera el entorno
            SQLDisconnect(hDbc);
            SQLFreeHandle(SQL_HANDLE_DBC, hDbc);
            SQLFreeHandle(SQL_HANDLE_ENV, hEnv);
            return 0;
        }
    }
}
