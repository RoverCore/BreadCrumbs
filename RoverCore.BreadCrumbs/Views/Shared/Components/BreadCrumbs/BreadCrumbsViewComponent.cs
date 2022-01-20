using Microsoft.AspNetCore.Mvc;
using RoverCore.BreadCrumbs.Models;
using RoverCore.BreadCrumbs.Services;

namespace RoverCore.BreadCrumbs.Views.Shared.Components.BreadCrumbs;

public class BreadCrumbsViewComponent : ViewComponent
{
    private readonly IBreadCrumbService _breadCrumbService;

    public BreadCrumbsViewComponent(IBreadCrumbService breadCrumbService)
    {
        _breadCrumbService = breadCrumbService;
    }

    public IViewComponentResult Invoke()
    {
        var home = _breadCrumbService.BreadCrumbs.First();
        var rest = _breadCrumbService.BreadCrumbs.Skip(1).ToList();
        var current = rest?.LastOrDefault();

        if (rest?.Count > 0)
        {
            rest = rest.Take(rest.Count() - 1).ToList();
        }

        BreadCrumbViewModel vm = new BreadCrumbViewModel
        {
            Home = home,
            Intermediate = rest ?? new List<BreadCrumb>(),
            Current = current
        };

        return View(vm);
    }
}