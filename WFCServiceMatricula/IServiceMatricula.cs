using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace WFCServiceMatricula
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceMatricula
    {

        [OperationContract]
        DataSet ListarMatriculas();

        [OperationContract]
        DataSet BuscarporMatricula(int id);

        [OperationContract]
        String RegistrarMatricula(Matricula obj_matricula);

        [OperationContract]
        String ActualizarMatricula(Matricula obj_matricula);

        [OperationContract]
        String EliminarMatricula(Matricula obj_matricula);




        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    

    public class Matricula
    {
        [DataMember]
        public int id_matricula { get; set; }

        [DataMember]
        public String nombre { get; set; }

        [DataMember]
        public String apellido { get; set; }

        [DataMember]
        public String dni { get; set; }

        [DataMember]
        public String nivel { get; set; }

        [DataMember]
        public String turno { get; set; }

        [DataMember]
        public String grado { get; set; }

        [DataMember]
        public String seccion { get; set; }

        [DataMember]
        public String apoderado { get; set; }

        [DataMember]
        public String telefono { get; set; }


    }

}
