﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Medico.Web.ERPAgendamento {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Agendamento", Namespace="http://localhost:3004/")]
    [System.SerializableAttribute()]
    public partial class Agendamento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int medico_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string medico_nomeField;
        
        private int paciente_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string paciente_nomeField;
        
        private System.DateTime dataAtendimentoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int medico_id {
            get {
                return this.medico_idField;
            }
            set {
                if ((this.medico_idField.Equals(value) != true)) {
                    this.medico_idField = value;
                    this.RaisePropertyChanged("medico_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string medico_nome {
            get {
                return this.medico_nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.medico_nomeField, value) != true)) {
                    this.medico_nomeField = value;
                    this.RaisePropertyChanged("medico_nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int paciente_id {
            get {
                return this.paciente_idField;
            }
            set {
                if ((this.paciente_idField.Equals(value) != true)) {
                    this.paciente_idField = value;
                    this.RaisePropertyChanged("paciente_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string paciente_nome {
            get {
                return this.paciente_nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.paciente_nomeField, value) != true)) {
                    this.paciente_nomeField = value;
                    this.RaisePropertyChanged("paciente_nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime dataAtendimento {
            get {
                return this.dataAtendimentoField;
            }
            set {
                if ((this.dataAtendimentoField.Equals(value) != true)) {
                    this.dataAtendimentoField = value;
                    this.RaisePropertyChanged("dataAtendimento");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paciente", Namespace="http://localhost:3004/")]
    [System.SerializableAttribute()]
    public partial class Paciente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string rgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cpfField;
        
        private System.DateTime data_nascimentoField;
        
        private int pesoField;
        
        private int alturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipo_sanguineoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string afiliacao_paiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string afiliacao_maeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string endereco_residencialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefone_residencialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string endereco_comercialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefone_comercialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefone_celularField;
        
        private int convenioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string rg {
            get {
                return this.rgField;
            }
            set {
                if ((object.ReferenceEquals(this.rgField, value) != true)) {
                    this.rgField = value;
                    this.RaisePropertyChanged("rg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string cpf {
            get {
                return this.cpfField;
            }
            set {
                if ((object.ReferenceEquals(this.cpfField, value) != true)) {
                    this.cpfField = value;
                    this.RaisePropertyChanged("cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime data_nascimento {
            get {
                return this.data_nascimentoField;
            }
            set {
                if ((this.data_nascimentoField.Equals(value) != true)) {
                    this.data_nascimentoField = value;
                    this.RaisePropertyChanged("data_nascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int peso {
            get {
                return this.pesoField;
            }
            set {
                if ((this.pesoField.Equals(value) != true)) {
                    this.pesoField = value;
                    this.RaisePropertyChanged("peso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int altura {
            get {
                return this.alturaField;
            }
            set {
                if ((this.alturaField.Equals(value) != true)) {
                    this.alturaField = value;
                    this.RaisePropertyChanged("altura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string tipo_sanguineo {
            get {
                return this.tipo_sanguineoField;
            }
            set {
                if ((object.ReferenceEquals(this.tipo_sanguineoField, value) != true)) {
                    this.tipo_sanguineoField = value;
                    this.RaisePropertyChanged("tipo_sanguineo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string afiliacao_pai {
            get {
                return this.afiliacao_paiField;
            }
            set {
                if ((object.ReferenceEquals(this.afiliacao_paiField, value) != true)) {
                    this.afiliacao_paiField = value;
                    this.RaisePropertyChanged("afiliacao_pai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string afiliacao_mae {
            get {
                return this.afiliacao_maeField;
            }
            set {
                if ((object.ReferenceEquals(this.afiliacao_maeField, value) != true)) {
                    this.afiliacao_maeField = value;
                    this.RaisePropertyChanged("afiliacao_mae");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string endereco_residencial {
            get {
                return this.endereco_residencialField;
            }
            set {
                if ((object.ReferenceEquals(this.endereco_residencialField, value) != true)) {
                    this.endereco_residencialField = value;
                    this.RaisePropertyChanged("endereco_residencial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string telefone_residencial {
            get {
                return this.telefone_residencialField;
            }
            set {
                if ((object.ReferenceEquals(this.telefone_residencialField, value) != true)) {
                    this.telefone_residencialField = value;
                    this.RaisePropertyChanged("telefone_residencial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string endereco_comercial {
            get {
                return this.endereco_comercialField;
            }
            set {
                if ((object.ReferenceEquals(this.endereco_comercialField, value) != true)) {
                    this.endereco_comercialField = value;
                    this.RaisePropertyChanged("endereco_comercial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string telefone_comercial {
            get {
                return this.telefone_comercialField;
            }
            set {
                if ((object.ReferenceEquals(this.telefone_comercialField, value) != true)) {
                    this.telefone_comercialField = value;
                    this.RaisePropertyChanged("telefone_comercial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string telefone_celular {
            get {
                return this.telefone_celularField;
            }
            set {
                if ((object.ReferenceEquals(this.telefone_celularField, value) != true)) {
                    this.telefone_celularField = value;
                    this.RaisePropertyChanged("telefone_celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=14)]
        public int convenio {
            get {
                return this.convenioField;
            }
            set {
                if ((this.convenioField.Equals(value) != true)) {
                    this.convenioField = value;
                    this.RaisePropertyChanged("convenio");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:3004/", ConfigurationName="ERPAgendamento.FornecedorServicosSoap")]
    public interface FornecedorServicosSoap {
        
        // CODEGEN: Generating message contract since element name AgendamentosByMedicosResult from namespace http://localhost:3004/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:3004/AgendamentosByMedicos", ReplyAction="*")]
        ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosResponse AgendamentosByMedicos(ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequest request);
        
        // CODEGEN: Generating message contract since element name PacienteByIdResult from namespace http://localhost:3004/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:3004/PacienteById", ReplyAction="*")]
        ERP.Medico.Web.ERPAgendamento.PacienteByIdResponse PacienteById(ERP.Medico.Web.ERPAgendamento.PacienteByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:3004/NotificarManutencao", ReplyAction="*")]
        void NotificarManutencao(System.DateTime dataInicio, System.DateTime dataFim, int salaId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:3004/NotificarFerias", ReplyAction="*")]
        void NotificarFerias(System.DateTime dataInicio, System.DateTime dataFim, int medicoId);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgendamentosByMedicosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgendamentosByMedicos", Namespace="http://localhost:3004/", Order=0)]
        public ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequestBody Body;
        
        public AgendamentosByMedicosRequest() {
        }
        
        public AgendamentosByMedicosRequest(ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost:3004/")]
    public partial class AgendamentosByMedicosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public AgendamentosByMedicosRequestBody() {
        }
        
        public AgendamentosByMedicosRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgendamentosByMedicosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgendamentosByMedicosResponse", Namespace="http://localhost:3004/", Order=0)]
        public ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosResponseBody Body;
        
        public AgendamentosByMedicosResponse() {
        }
        
        public AgendamentosByMedicosResponse(ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost:3004/")]
    public partial class AgendamentosByMedicosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<ERP.Medico.Web.ERPAgendamento.Agendamento> AgendamentosByMedicosResult;
        
        public AgendamentosByMedicosResponseBody() {
        }
        
        public AgendamentosByMedicosResponseBody(System.Collections.Generic.List<ERP.Medico.Web.ERPAgendamento.Agendamento> AgendamentosByMedicosResult) {
            this.AgendamentosByMedicosResult = AgendamentosByMedicosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PacienteByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PacienteById", Namespace="http://localhost:3004/", Order=0)]
        public ERP.Medico.Web.ERPAgendamento.PacienteByIdRequestBody Body;
        
        public PacienteByIdRequest() {
        }
        
        public PacienteByIdRequest(ERP.Medico.Web.ERPAgendamento.PacienteByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost:3004/")]
    public partial class PacienteByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public PacienteByIdRequestBody() {
        }
        
        public PacienteByIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PacienteByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PacienteByIdResponse", Namespace="http://localhost:3004/", Order=0)]
        public ERP.Medico.Web.ERPAgendamento.PacienteByIdResponseBody Body;
        
        public PacienteByIdResponse() {
        }
        
        public PacienteByIdResponse(ERP.Medico.Web.ERPAgendamento.PacienteByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost:3004/")]
    public partial class PacienteByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ERP.Medico.Web.ERPAgendamento.Paciente PacienteByIdResult;
        
        public PacienteByIdResponseBody() {
        }
        
        public PacienteByIdResponseBody(ERP.Medico.Web.ERPAgendamento.Paciente PacienteByIdResult) {
            this.PacienteByIdResult = PacienteByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FornecedorServicosSoapChannel : ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FornecedorServicosSoapClient : System.ServiceModel.ClientBase<ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap>, ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap {
        
        public FornecedorServicosSoapClient() {
        }
        
        public FornecedorServicosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FornecedorServicosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FornecedorServicosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FornecedorServicosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosResponse ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap.AgendamentosByMedicos(ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequest request) {
            return base.Channel.AgendamentosByMedicos(request);
        }
        
        public System.Collections.Generic.List<ERP.Medico.Web.ERPAgendamento.Agendamento> AgendamentosByMedicos(int id) {
            ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequest inValue = new ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequest();
            inValue.Body = new ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosRequestBody();
            inValue.Body.id = id;
            ERP.Medico.Web.ERPAgendamento.AgendamentosByMedicosResponse retVal = ((ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap)(this)).AgendamentosByMedicos(inValue);
            return retVal.Body.AgendamentosByMedicosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ERP.Medico.Web.ERPAgendamento.PacienteByIdResponse ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap.PacienteById(ERP.Medico.Web.ERPAgendamento.PacienteByIdRequest request) {
            return base.Channel.PacienteById(request);
        }
        
        public ERP.Medico.Web.ERPAgendamento.Paciente PacienteById(int id) {
            ERP.Medico.Web.ERPAgendamento.PacienteByIdRequest inValue = new ERP.Medico.Web.ERPAgendamento.PacienteByIdRequest();
            inValue.Body = new ERP.Medico.Web.ERPAgendamento.PacienteByIdRequestBody();
            inValue.Body.id = id;
            ERP.Medico.Web.ERPAgendamento.PacienteByIdResponse retVal = ((ERP.Medico.Web.ERPAgendamento.FornecedorServicosSoap)(this)).PacienteById(inValue);
            return retVal.Body.PacienteByIdResult;
        }
        
        public void NotificarManutencao(System.DateTime dataInicio, System.DateTime dataFim, int salaId) {
            base.Channel.NotificarManutencao(dataInicio, dataFim, salaId);
        }
        
        public void NotificarFerias(System.DateTime dataInicio, System.DateTime dataFim, int medicoId) {
            base.Channel.NotificarFerias(dataInicio, dataFim, medicoId);
        }
    }
}
