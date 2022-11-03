using Platform.Models;
using Platform.Services;
using Microsoft.AspNetCore.Mvc;

namespace Platform.Controllers {


[Route( "api/[controller]" )]
public class RecordController : ControllerBase
{

    public RecordController() {
    }
    // GET all action
	[HttpGet]
	public ActionResult<List<Record>> GetAll() =>
		 RecordService.GetAll();
    // GET by Id action
	[HttpGet("{id}")]
	public ActionResult<Record> Get(int id)
	{
	    var record = RecordService.Get(id);

	    if(record == null)
	        return NotFound();

	    return record;
	}
    // POST action
    [HttpPost]

    public IActionResult Create(Record record) {            
    // This code will save the pizza and return a result
      RecordService.Add(record);
      return CreatedAtAction(nameof(Create), new { id = record.Id }, record);
    }
    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Record record)
    {
        // This code will update the pizza and return a result
        if (id != record.Id)
            return BadRequest();
           
        var existingRecord = RecordService.Get(id);
        if(existingRecord is null)
            return NotFound();
   
        RecordService.Update(record);           
        return NoContent();
    }
    
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
{
        var record = RecordService.Get(id);
   
        if (record is null)
            return NotFound();
       
        RecordService.Delete(id);
   
        return NoContent();
}
    }


}