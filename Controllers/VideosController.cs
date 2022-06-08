using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using asp.net_folder.Models2;

namespace asp.net_folder.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly VideoCollectionContext _context;

        public VideosController(VideoCollectionContext context)
        {
            _context = context;
        }

        // GET: api/Videos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideoCollection>>> GetVideoCollections()
        {
          if (_context.VideoCollections == null)
          {
              return NotFound();
          }
            return await _context.VideoCollections.ToListAsync();
        }

        // GET: api/Videos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VideoCollection>> GetVideoCollection(int id)
        {
          if (_context.VideoCollections == null)
          {
              return NotFound();
          }
            var videoCollection = await _context.VideoCollections.FindAsync(id);

            if (videoCollection == null)
            {
                return NotFound();
            }

            return videoCollection;
        }

        // PUT: api/Videos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVideoCollection(int id, VideoCollection videoCollection)
        {
            if (id != videoCollection.Id)
            {
                return BadRequest();
            }

            _context.Entry(videoCollection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideoCollectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Videos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VideoCollection>> PostVideoCollection(VideoCollection videoCollection)
        {
          if (_context.VideoCollections == null)
          {
              return Problem("Entity set 'VideoCollectionContext.VideoCollections'  is null.");
          }
            _context.VideoCollections.Add(videoCollection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVideoCollection", new { id = videoCollection.Id }, videoCollection);
        }

        // DELETE: api/Videos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoCollection(int id)
        {
            if (_context.VideoCollections == null)
            {
                return NotFound();
            }
            var videoCollection = await _context.VideoCollections.FindAsync(id);
            if (videoCollection == null)
            {
                return NotFound();
            }

            _context.VideoCollections.Remove(videoCollection);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VideoCollectionExists(int id)
        {
            return (_context.VideoCollections?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
