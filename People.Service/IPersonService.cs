using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace People.Service
{	
	[ServiceContract]
	public interface IPersonService
	{

		[OperationContract]
		List<Person> GetPeople();

		[OperationContract]
		Person GetPerson(string lastName);

		[OperationContract]
		void AddPerson(Person newPerson);

		[OperationContract]
		void UpdatePerson(string lastName, Person updatedPerson);

		[OperationContract]
		void UpdatePeople(List<Person> updatedPeople);

		[OperationContract]
		void DeletePerson(string lastName);
	}
}
