using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternshipAssignment.Data;
using InternshipAssignment.Models;
using Microsoft.AspNetCore.Http;

namespace InternshipAssignment.Controllers
{
    public class CvModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CvModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CvModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CvModel.Include(c => c.Department).Include(c => c.GenderModel).Include(c => c.Language).Include(c => c.MaritalStatus).Include(c => c.Religion);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CvModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _context.CvModel
                .Include(c => c.Department)
                .Include(c => c.GenderModel)
                .Include(c => c.Language)
                .Include(c => c.MaritalStatus)
                .Include(c => c.Religion)
                .SingleOrDefaultAsync(m => m.CvId == id);
            if (cvModel == null)
            {
                return NotFound();
            }

            return View(cvModel);
        }

        // GET: CvModels/Create
        public IActionResult Create()
        {
            ViewData["DeptId"] = new SelectList(_context.Department, "DeptId", "DeptName");
            ViewData["GenderId"] = new SelectList(_context.GenderModel, "GenderId", "GenderName");
            ViewData["LanguageId"] = new SelectList(_context.Language, "LanguageId", "LanguageName");
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatus, "MaritalStatusId", "MaritalStatusName");
            ViewData["ReligionId"] = new SelectList(_context.Religion, "ReligionId", "ReligionName");
            return View();
        }

        // POST: CvModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CvId,YourName,DeptId,UniversityName,YourEmail,YourPhone,ProfileImage,CareerObjective,AcademicQualification,TechnicalSkillTitleOne,TechnicalSkillContentOne,TechnicalSkillTitleTwo,TechnicalSkillContentTwo,TechnicalSkillTitleThree,TechnicalSkillContentThree,TechnicalSkillTitleFour,TechnicalSkillContentFour,TechnicalSkillTitleFive,TechnicalSkillContentFive,ProjectNameOne,ProjectContentOne,ProjectNameTwo,ProjectContentTwo,ProjectNameThree,ProjectContentThree,ProjectNameFour,ProjectContentFour,ProjectNameFive,ProjectContentFive,ExtraCurricularOne,ExtraCurricularTwo,ExtraCurricularThree,ExtraCurricularFour,ExtraCurricularFive,FieldOfInterest,LanguageId,LanguageTwo,LanguageThree,FatherName,MotherName,DateOfBirth,GenderId,MaritalStatusId,Nationality,NIDNumber,ReligionId,PermanentAddress,CurrentAddress,TeacherNameOne,PositionOne,EmailOne,PhoneOne,TeacherNameTwo,PositionTwo,EmailTwo,PhoneTwo")] CvModel cvModel, IFormFile image)
        {

            if (image.Length > 0)
            {
                    byte[] p1 = null;

                    using (var fs1 = image.OpenReadStream())
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();

                        cvModel.ProfileImage = p1;
                    }
                    _context.Add(cvModel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
            }


            
            ViewData["DeptId"] = new SelectList(_context.Department, "DeptId", "DeptName", cvModel.DeptId);
            ViewData["GenderId"] = new SelectList(_context.GenderModel, "GenderId", "GenderName", cvModel.GenderId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "LanguageId", "LanguageName", cvModel.LanguageId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatus, "MaritalStatusId", "MaritalStatusName", cvModel.MaritalStatusId);
            ViewData["ReligionId"] = new SelectList(_context.Religion, "ReligionId", "ReligionName", cvModel.ReligionId);
            return View(cvModel);
        }

        // GET: CvModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _context.CvModel.SingleOrDefaultAsync(m => m.CvId == id);
            if (cvModel == null)
            {
                return NotFound();
            }
            ViewData["DeptId"] = new SelectList(_context.Department, "DeptId", "DeptName", cvModel.DeptId);
            ViewData["GenderId"] = new SelectList(_context.GenderModel, "GenderId", "GenderName", cvModel.GenderId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "LanguageId", "LanguageName", cvModel.LanguageId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatus, "MaritalStatusId", "MaritalStatusName", cvModel.MaritalStatusId);
            ViewData["ReligionId"] = new SelectList(_context.Religion, "ReligionId", "ReligionName", cvModel.ReligionId);
            return View(cvModel);
        }

        // POST: CvModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CvId,YourName,DeptId,UniversityName,YourEmail,YourPhone,ProfileImage,CareerObjective,AcademicQualification,TechnicalSkillTitleOne,TechnicalSkillContentOne,TechnicalSkillTitleTwo,TechnicalSkillContentTwo,TechnicalSkillTitleThree,TechnicalSkillContentThree,TechnicalSkillTitleFour,TechnicalSkillContentFour,TechnicalSkillTitleFive,TechnicalSkillContentFive,ProjectNameOne,ProjectContentOne,ProjectNameTwo,ProjectContentTwo,ProjectNameThree,ProjectContentThree,ProjectNameFour,ProjectContentFour,ProjectNameFive,ProjectContentFive,ExtraCurricularOne,ExtraCurricularTwo,ExtraCurricularThree,ExtraCurricularFour,ExtraCurricularFive,FieldOfInterest,LanguageId,LanguageTwo,LanguageThree,FatherName,MotherName,DateOfBirth,GenderId,MaritalStatusId,Nationality,NIDNumber,ReligionId,PermanentAddress,CurrentAddress,TeacherNameOne,PositionOne,EmailOne,PhoneOne,TeacherNameTwo,PositionTwo,EmailTwo,PhoneTwo")] CvModel cvModel, IFormFile image)
        {
            if (id != cvModel.CvId)
            {
                return NotFound();
            }

            if (image.Length > 0)
            {
                
                byte[] p1 = null;

                using (var fs1 = image.OpenReadStream())
                using (var ms1 = new MemoryStream())
                {
                    fs1.CopyTo(ms1);
                    p1 = ms1.ToArray();

                    cvModel.ProfileImage = p1;
                }

                try
                {
                    _context.Update(cvModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CvModelExists(cvModel.CvId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptId"] = new SelectList(_context.Department, "DeptId", "DeptName", cvModel.DeptId);
            ViewData["GenderId"] = new SelectList(_context.GenderModel, "GenderId", "GenderName", cvModel.GenderId);
            ViewData["LanguageId"] = new SelectList(_context.Language, "LanguageId", "LanguageName", cvModel.LanguageId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatus, "MaritalStatusId", "MaritalStatusName", cvModel.MaritalStatusId);
            ViewData["ReligionId"] = new SelectList(_context.Religion, "ReligionId", "ReligionName", cvModel.ReligionId);
            return View(cvModel);
        }

        // GET: CvModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cvModel = await _context.CvModel
                .Include(c => c.Department)
                .Include(c => c.GenderModel)
                .Include(c => c.Language)
                .Include(c => c.MaritalStatus)
                .Include(c => c.Religion)
                .SingleOrDefaultAsync(m => m.CvId == id);
            if (cvModel == null)
            {
                return NotFound();
            }

            return View(cvModel);
        }

        // POST: CvModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cvModel = await _context.CvModel.SingleOrDefaultAsync(m => m.CvId == id);
            _context.CvModel.Remove(cvModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CvModelExists(int id)
        {
            return _context.CvModel.Any(e => e.CvId == id);
        }
    }
}
