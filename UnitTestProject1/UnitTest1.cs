using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using лаб19;

namespace Lab19Tests
{
    [TestClass]
    public class PatientDatabaseTests
    {
        private static readonly string TestFilePath = "test_patients.dat";

        [TestInitialize]
        public void TestInitialize()
        {
            // Ensure test file does not exist before each test
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Cleanup test file after each test
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TestMethod]
        public void TestAddPatient()
        {
            // Arrange
            var patient = new Patient
            {
                FullName = "Test Patient",
                BirthYear = 1990,
                AdmissionDate = DateTime.Now,
                PreliminaryDiagnosis = "Test Diagnosis",
                DepartmentNumber = 1
            };

            // Act
            PatientDatabase.AddPatient(patient, TestFilePath);
            var patients = PatientDatabase.LoadPatients(TestFilePath);

            // Assert
            Assert.AreEqual(1, patients.Count);
            Assert.AreEqual("Test Patient", patients[0].FullName);
        }

        [TestMethod]
        public void TestUpdatePatient()
        {
            // Arrange
            var patient = new Patient
            {
                FullName = "Test Patient",
                BirthYear = 1990,
                AdmissionDate = DateTime.Now,
                PreliminaryDiagnosis = "Test Diagnosis",
                DepartmentNumber = 1
            };

            var updatedPatient = new Patient
            {
                FullName = "Test Patient",
                BirthYear = 1995,
                AdmissionDate = DateTime.Now,
                PreliminaryDiagnosis = "Updated Diagnosis",
                DepartmentNumber = 2
            };

            // Act
            PatientDatabase.AddPatient(patient, TestFilePath);
            PatientDatabase.UpdatePatient("Test Patient", updatedPatient, TestFilePath);
            var patients = PatientDatabase.LoadPatients(TestFilePath);

            // Assert
            Assert.AreEqual(1, patients.Count);
            Assert.AreEqual(1995, patients[0].BirthYear);
            Assert.AreEqual("Updated Diagnosis", patients[0].PreliminaryDiagnosis);
        }

        [TestMethod]
        public void TestSearchPatients()
        {
            // Arrange
            var patient1 = new Patient
            {
                FullName = "Patient One",
                BirthYear = 1990,
                AdmissionDate = DateTime.Now,
                PreliminaryDiagnosis = "Diagnosis One",
                DepartmentNumber = 1
            };

            var patient2 = new Patient
            {
                FullName = "Patient Two",
                BirthYear = 1995,
                AdmissionDate = DateTime.Now,
                PreliminaryDiagnosis = "Diagnosis Two",
                DepartmentNumber = 2
            };

            // Act
            PatientDatabase.AddPatient(patient1, TestFilePath);
            PatientDatabase.AddPatient(patient2, TestFilePath);
            var searchResults = PatientDatabase.SearchPatients("One", TestFilePath);

            // Assert
            Assert.AreEqual(1, searchResults.Count);
            Assert.AreEqual("Patient One", searchResults[0].FullName);
        }
    }
}
