﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using PersonRepository.Interface;
namespace MyService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IPersonService")]
    public interface IPersonService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        System.Collections.Generic.List<Person> GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPeople", ReplyAction="http://tempuri.org/IPersonService/GetPeopleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Person>> GetPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        Person GetPerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPerson", ReplyAction="http://tempuri.org/IPersonService/GetPersonResponse")]
        System.Threading.Tasks.Task<Person> GetPersonAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        void AddPerson(Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/AddPerson", ReplyAction="http://tempuri.org/IPersonService/AddPersonResponse")]
        System.Threading.Tasks.Task AddPersonAsync(Person newPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        void UpdatePerson(string lastName, Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(string lastName, Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePeople", ReplyAction="http://tempuri.org/IPersonService/UpdatePeopleResponse")]
        void UpdatePeople(System.Collections.Generic.List<Person> updatedPeople);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePeople", ReplyAction="http://tempuri.org/IPersonService/UpdatePeopleResponse")]
        System.Threading.Tasks.Task UpdatePeopleAsync(System.Collections.Generic.List<Person> updatedPeople);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        void DeletePerson(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(string lastName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IPersonServiceChannel : MyService.IPersonService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<MyService.IPersonService>, MyService.IPersonService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PersonServiceClient() : 
                base(PersonServiceClient.GetDefaultBinding(), PersonServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPersonService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PersonServiceClient.GetBindingForEndpoint(endpointConfiguration), PersonServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PersonServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PersonServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<PersonRepository.Interface.Person> GetPeople()
        {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<PersonRepository.Interface.Person>> GetPeopleAsync()
        {
            return base.Channel.GetPeopleAsync();
        }
        
        public PersonRepository.Interface.Person GetPerson(string lastName)
        {
            return base.Channel.GetPerson(lastName);
        }
        
        public System.Threading.Tasks.Task<PersonRepository.Interface.Person> GetPersonAsync(string lastName)
        {
            return base.Channel.GetPersonAsync(lastName);
        }
        
        public void AddPerson(PersonRepository.Interface.Person newPerson)
        {
            base.Channel.AddPerson(newPerson);
        }
        
        public System.Threading.Tasks.Task AddPersonAsync(PersonRepository.Interface.Person newPerson)
        {
            return base.Channel.AddPersonAsync(newPerson);
        }
        
        public void UpdatePerson(string lastName, PersonRepository.Interface.Person updatedPerson)
        {
            base.Channel.UpdatePerson(lastName, updatedPerson);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(string lastName, PersonRepository.Interface.Person updatedPerson)
        {
            return base.Channel.UpdatePersonAsync(lastName, updatedPerson);
        }
        
        public void UpdatePeople(System.Collections.Generic.List<PersonRepository.Interface.Person> updatedPeople)
        {
            base.Channel.UpdatePeople(updatedPeople);
        }
        
        public System.Threading.Tasks.Task UpdatePeopleAsync(System.Collections.Generic.List<PersonRepository.Interface.Person> updatedPeople)
        {
            return base.Channel.UpdatePeopleAsync(updatedPeople);
        }
        
        public void DeletePerson(string lastName)
        {
            base.Channel.DeletePerson(lastName);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(string lastName)
        {
            return base.Channel.DeletePersonAsync(lastName);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPersonService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPersonService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:56870/PersonService.svc/PersonService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PersonServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPersonService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PersonServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPersonService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPersonService,
        }
    }
}
