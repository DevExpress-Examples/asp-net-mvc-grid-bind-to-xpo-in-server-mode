Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata

''' <summary>
''' Summary description for XpoHelper
''' </summary>
Public NotInheritable Class XpoHelper
	Private Sub New()
	End Sub
	Shared Sub New()
		CreateDefaultObjects()
	End Sub

	Public Shared Function GetNewSession() As Session
		Return New Session(DataLayer)
	End Function

	Public Shared Function GetNewUnitOfWork() As UnitOfWork
		Return New UnitOfWork(DataLayer)
	End Function

	Private ReadOnly Shared lockObject As Object = New Object()

	Private Shared fDataLayer As IDataLayer
	Private Shared ReadOnly Property DataLayer() As IDataLayer
		Get
			If fDataLayer Is Nothing Then
				SyncLock lockObject
					fDataLayer = GetDataLayer()
				End SyncLock
			End If
			Return fDataLayer
		End Get
	End Property

	Private Shared Function GetDataLayer() As IDataLayer
		XpoDefault.Session = Nothing

		Dim ds As New InMemoryDataStore()

		Dim dict As XPDictionary = New ReflectionDictionary()
		dict.GetDataStoreSchema(GetType(MyObject).Assembly)

		Return New ThreadSafeDataLayer(dict, ds)
	End Function

	Private Shared Sub CreateDefaultObjects()
		Using uow As UnitOfWork = GetNewUnitOfWork()
			Dim obj As MyObject = Nothing

			For i As Int32 = 0 To 1233
				obj = New MyObject(uow)
				obj.Title = "Item " & i.ToString()
			Next i

			uow.CommitChanges()
		End Using
	End Sub
End Class