using Microsoft.AspNetCore.Mvc;
using ReadableCodeTraining.Api.Dtos;
using ReadableCodeTraining.Api.Dtos.Seeds;

[ApiController]
[Route("api/lessons")]
public class LessonsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<LessonDto>> GetLessons()
    {
        var lessons = LessonSeed.Lessons
            .OrderBy(lesson => lesson.DisplayOrder)
            .ToList();

        return Ok(lessons);
    }
}