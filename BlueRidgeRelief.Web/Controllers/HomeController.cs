using BlueRidgeRelief.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AutoMapper;
using BlueRidgeRelief.Core.Interfaces;
using BlueRidgeRelief.DTOs;

namespace BlueRidgeRelief.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INeedsService _needsService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, INeedsService needsService, IMapper mapper)
        {
            _logger = logger;
            _needsService = needsService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var needs = await _needsService.GetSortedNeedsAsync();
            var needsDto = _mapper.Map<IEnumerable<NeedDto>>(needs);
            return View(needsDto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
