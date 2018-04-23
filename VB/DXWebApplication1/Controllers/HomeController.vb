Imports System
Imports System.Web.Mvc
Imports DXWebApplication1.Models

Namespace DXWebApplication1.Controllers
	Public Class HomeController
		Inherits Controller

		Private list As New PersonsList()

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(list.GetPersons())
		End Function

		<HttpPost, ValidateInput(False)>
		Public Function EditingAddNew(ByVal person As Person) As ActionResult
			If ModelState.IsValid Then
				list.AddPerson(person)
			End If
			Return PartialView("GridViewPartial", list.GetPersons())
		End Function

		<HttpPost, ValidateInput(False)>
		Public Function EditingUpdate(ByVal personInfo As Person) As ActionResult
			If ModelState.IsValid Then
				list.UpdatePerson(personInfo)
			End If
			Return PartialView("GridViewPartial", list.GetPersons())
		End Function

		Public Function EditingDelete(ByVal personId As Integer) As ActionResult
			list.DeletePerson(personId)
			Return PartialView("GridViewPartial", list.GetPersons())
		End Function
	End Class
End Namespace