using Microsoft.EntityFrameworkCore;
using BandaddressApi.Data;
using BandaddressApi.Models;

namespace BandaddressApi.Controllers;

/// <summary>
/// OData-Controller für die City-Entität.
/// Erbt die gesamte CRUD-Logik von ODataCrudController (DRY, B-08).
/// Endpunkte: GET/POST/PATCH/DELETE /odata/Cities
/// </summary>
public class CitiesController : ODataCrudController<City>
{
    protected override DbSet<City> Entities     => _context.Cities;
    protected override string EntityDisplayName => "Stadt";

    public CitiesController(AdresseDbContext context) : base(context) { }
}
