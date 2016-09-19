using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using ProjetoModeloDDD.Application.Interface;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        //private readonly RepositoryUsuario _repositoryUsuario = new RepositoryUsuario();

        private readonly IAppServiceUsuario _appUsuario;

        public UsuarioController(IAppServiceUsuario appUsuario)
        {
            _appUsuario = appUsuario;
        }



        // GET: Usuario
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_appUsuario.GetAll());
            //return View();
            return View(usuarioViewModel);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _appUsuario.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)//Create(FormCollection collection)
        {

            if(ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _appUsuario.Add(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _appUsuario.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _appUsuario.Add(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);

        }
        
        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _appUsuario.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UsuarioViewModel usuario)
        {
           if(ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _appUsuario.Add(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }
        // POST: Usuario/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
