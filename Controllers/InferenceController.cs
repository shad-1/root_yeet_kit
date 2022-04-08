﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using YeetCarAccidents.Models;

namespace YeetCarAccidents.Controllers
{
    public class InferenceController : Controller
    {
        private InferenceSession _session;

        public InferenceController(InferenceSession session)
        {
            _session = session;
        }
        [Route("Inference/Testagain")]
        [HttpGet]
        public IActionResult TestAgain()
        {
            var plsMod = new TestModel();
            return View(plsMod);
        }
        [Route("Inference/PrintTest")]
        [HttpPost]
        public IActionResult PrintTest(TestModel plsMod)
        {
            ViewBag.val = plsMod.chec;
            return View();
        }
        [Route("Inference/Calculator")]
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }
        [Route("Inference/Test")]
        [HttpPost]
        public IActionResult Test(CrashData data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_imput", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new SeverityPrediction { Crash_severity_id = score.First() };
            result.Dispose();
            return View("Test", prediction);
        }
    }
}