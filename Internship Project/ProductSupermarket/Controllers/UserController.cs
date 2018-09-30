 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductSupermarket.Entities;
using ProductSupermarket.Repositories;
namespace ProductSupermarket.Controllers{
	
	public class UserController:Controller {
		
		public ActionResult Index() {
			List<Users> users = new List<Users>();
			UserRepository userRepository = new UserRepository();
			users.AddRange(userRepository.GetAll());
			return View(users);
			
		}
		[HttpGet]
		public ActionResult Create(){
			return View();
		}
		
		[HttpPost]
		public ActionResult Create(User entity){
			
			entity.CreatedAt = DateTime.Now;
			entity.LastUpdateAt = DateTime.Now;
			entity.IsActive = false;
			entity.AccessRights = NormalUser;
			
			
			var userRepository = new UserRepository();
			userRepository.Insert(entity);
			
			return RedirecToAction("Index");
		}
		
		[HttpGet]
		public ActionResult Update(int id) {
			
			var userRepository = new UserRepository();
			User entity = userRepository.GetById(id);
			
			return View(entity);
		}
		
		[HttpPost]
		public ActionResult Update(User entity) {
			entity.LastUpdateAt = DateTime.Now;
			var userRepository = new UserRepository();
			userRepository.Update(entity);
			
			return RedirecToAction("Inedx");
			
		}
		
		public ActionResult Delete(int id) {
			var userRepository = new UserRepository();
			var entity = userRepository.GetById(id);
			userRepository.Delete(entity);
			
			return RedirecToAction("Index");
		}
		
	}
}