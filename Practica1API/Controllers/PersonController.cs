using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Practica1API.Repositories;
using Practica1API.Domain;

/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1  El alumno utilizará las API's para programar aplicaciones orientadas a servicios.
    Nombre del alumno: Rafael Salazar Perera
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2
    */
namespace Practica1API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        /// Escribe un método en el cual se retorne la información de todas las personas.
        [HttpGet]
        [Route("PERSONAS")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 
        /// Escribe un método en el cual se retorne únicamente el nombre completo de las personas, el correo y el año de nacimiento.
        [HttpGet]
        [Route("GetFields")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de todas las personas cuyo genero sea Femenino.
        [HttpGet]
        [Route("GetByGender")]
        public IActionResult GetByGender()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de todas las personas cuya edad se encuentre entre los 20 y 30 años.
        [HttpGet]
        [Route("GetByRangeAge")]
        public IActionResult GetByRangeAge()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de los diferentes trabajos que tienen las personas.
        [HttpGet]
        [Route("job")]
        public IActionResult GetDiferences()
        {
            var repository = new PersonRepository();
            var persons = repository.GetDiferences();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información de las personas cuyo nombre contenga lapalabra ar
        [HttpGet]
        [Route("GetContains")]
        public IActionResult GetContains()
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains();
            return Ok(persons);
        } 
        ///Escribe un método que retorna la información de las personas cuyas edades sean 25, 35 y 45 años
         [HttpGet]
         [Route("GetByAges")]
        public IActionResult GetByAges()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAges();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información ordenas por edad para las personas que sean mayores a 40 años
         [HttpGet]
         [Route("MayorCuarentaAños")]
        public IActionResult MayorCuarentaAños()
        {
            var repository = new PersonRepository();
            var persons = repository.MayorCuarentaAños();
            return Ok(persons);
        } 
        ///Escribe un método que retorne la información ordenada de manera descendente para todas las personas de género masculino y que se encuentren entre los 20 y 30 años de edad
         [HttpGet]
         [Route("GetPersonsOrderedDescending")]
        public IActionResult GetPersonsOrderedDescending()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDescending();
            return Ok(persons);
        }
        /// Escribe un método que retorne la cantidad de personas con género femenino. 
        [HttpGet]
        [Route("CountFemenino")]
        public IActionResult CountFemenino()
        {
            var repository = new PersonRepository();
            var persons = repository.CountFemenino();
            return Ok(persons);
        } 
        /// Escribe un método que retorna si existen personas con el apellido “Shemelt”.
        [HttpGet]
        [Route("ExistPerson")]
        public IActionResult ExistPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson();
            return Ok(persons);
        } 
        //Escribe un método que retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad
         [HttpGet]
         [Route("TakePersonAngAge")]
        public IActionResult TakePersonAngAge()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePersonAngAge();
            return Ok(persons);
        } 
        ///Escribe un método que omita la información de las primeras 3 personas cuyo puesto de  trabajo sea “Software Consultant”
        [HttpGet]
        [Route("TakePerson")]
        public IActionResult TakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson();
            return Ok(persons);
        } 
        ///Escribe un método que omita la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”
        [HttpGet]
        [Route("SkipPerson")]
        public IActionResult SkipPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson();
            return Ok(persons);
        } 
        ///Escribe un método que omita la información de las primeras 3 personas y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea “Software Consultant”
        [HttpGet]
        [Route("SkipTakePerson")]
        public IActionResult SkipTakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson();
            return Ok(persons);
        } 
        

    }
}