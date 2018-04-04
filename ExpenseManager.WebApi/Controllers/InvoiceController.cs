using ExpenseManager.Data.Domain.Invoice;
using ExpenseManager.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpenseManager.WebApi.Controllers
{
    public class InvoiceController : ApiController
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        // GET: api/Invoice
        [HttpGet]
        public IHttpActionResult Get()
        {
            var invoices = _invoiceService.GetAll();

            return Ok<IEnumerable<Invoice>>(invoices);
        }

        // GET: api/Invoice/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var invoice = _invoiceService.GetById(id);

            if (invoice == null)
                return NotFound();

            return Ok<Invoice>(invoice);
        }

        // POST: api/Invoice
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Invoice/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Invoice/5
        public void Delete(int id)
        {
        }
    }
}
