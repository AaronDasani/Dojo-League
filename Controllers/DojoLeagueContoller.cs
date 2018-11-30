using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using DojoLeague.Models;
using DojoLeague.Factory;
namespace DojoLeague
{
    public class DojoLeagueController:Controller
    {
        
        private readonly DojoNinjasFactory DN_Factory;
        public DojoLeagueController(){
            DN_Factory=new DojoNinjasFactory();
        }
        


        [HttpGet("")]
        [HttpGet("register")]
        public IActionResult register(){

            NinjaInfo ninjaInfo=new NinjaInfo();
           
            ninjaInfo.ninja=new Ninja();
            ninjaInfo.dojos=DN_Factory.FindAllDojos();
            ninjaInfo.ninjas=DN_Factory.FindAllNinjas();

            return View("register",ninjaInfo);
        }


        [HttpGet("allDojos")]
        public IActionResult allDojos(){
            DojoInfo dojoInfo=new DojoInfo();
            dojoInfo.dojos=DN_Factory.FindAllDojos();
            dojoInfo.dojo=new Dojo();
            return View("allDojos",dojoInfo);
        }

        [HttpGet("ninja/{ninja_id}")]
        public IActionResult ninja(long ninja_id)
        {
            var ninja=DN_Factory.FindNinjaById(ninja_id);
            return View("ninjaPage",ninja);
        }

        [HttpGet("dojo/{dojo_id}")]
        public IActionResult dojo(long dojo_id)
        {
            var dojoInfo=new DojoInfo();
            dojoInfo.dojo=DN_Factory.FindDojoById(dojo_id);
            dojoInfo.RogueNinjas=DN_Factory.FindAllRogueNinjas();
            
            return View("dojoPage",dojoInfo);
        }

        [HttpGet("recruit/{ninja_id}/{dojo_id}")]
        public IActionResult recruit(int ninja_id,int dojo_id){

            DN_Factory.RecruitNinja(ninja_id,dojo_id);

            return RedirectToAction("dojo",dojo_id);
        }
        
        [HttpGet("banish/{ninja_id}/{dojo_id}")]
        public IActionResult banish(int ninja_id,int dojo_id){

            DN_Factory.BanishNinja(ninja_id);

            return RedirectToAction("dojo",dojo_id);
        }





        // ---------Proccess fo Forms-------------

        [HttpPost("createNinja")]
        public IActionResult createNinja(NinjaInfo NInfo)
        {
            if (ModelState.IsValid)
            {
                DN_Factory.AddNinja(NInfo.ninja);
                return  RedirectToAction("register");
            }
            
            NinjaInfo ninjaInfo=new NinjaInfo();
            ninjaInfo.ninja=new Ninja();
            ninjaInfo.dojos=DN_Factory.FindAllDojos();
            ninjaInfo.ninjas=DN_Factory.FindAllNinjas();

            return View("register",ninjaInfo);
        }

        [HttpPost("createDojo")]
        public IActionResult createDojo(DojoInfo DInfo)
        {
            if (ModelState.IsValid)
            {
                DN_Factory.AddDojo(DInfo.dojo);
                return  RedirectToAction("allDojos");
            }
            
            DojoInfo dojoInfo=new DojoInfo();
            dojoInfo.dojos=DN_Factory.FindAllDojos();
            dojoInfo.dojo=new Dojo();

            return View("allDojos",dojoInfo);
        }
    }
}