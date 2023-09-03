using DeveloperTest.Exceptions;
using DeveloperTest.Models;
using DeveloperTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTest.Controllers;

public class ToDoController
{
    public ValidateService _validateService = new();
    private readonly ILogger<ToDoController> _logger;

    public ToDoController(ValidateService validateService, ILogger<ToDoController> logger)
    {
        _validateService = validateService;
        _logger = logger;
    }

    [HttpGet]
    [Route("/api/get/invoices")]
    [Authorize(AuthenticationSchemes = "ApiKey")]
    public IActionResult GetInvoices()
    {
        try
        {
            using (var context = new ToDoDbContext())
            {
                List<Invoice> invoices = context.Invoices.ToList();

                _validateService.ValidateInvoices(invoices);


            }
        }
        catch (ConnectionIsNotConfigured ex)
        {

            _logger.LogError(ex.Message);
        } 
        catch (InvoiceIsEmptyExcepiton ex)
        {

            _logger.LogError(ex.Message);
        }
        catch (InvoiceIsNull ex )
        {

            _logger.LogError(ex.Message);
        }
    }
    
}