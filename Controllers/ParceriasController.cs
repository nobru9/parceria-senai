using Microsoft.AspNetCore.Mvc;

public class ParceriasController:Controller{
    
    public IActionResult Index(){
        return View();
    }

    public IActionResult Oracle(){
        return View();
    }

    public IActionResult Cisco(){
        return View();
    }

    public IActionResult Huawei(){
        return View ();
    }

    public IActionResult Google(){
        return View();
    }
}