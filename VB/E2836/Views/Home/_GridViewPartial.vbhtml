@Imports E2836
@Html.DevExpress().GridView(Sub(settings)
                                     settings.Name = "gvDataBindingToLinq"
                                     settings.CallbackRouteValues = New With {
                                     Key .Controller = "Home",
                                     Key .Action = "GridViewPartial"
                                     }
                                     settings.KeyFieldName = "Oid"
                                     settings.Width = Unit.Percentage(100)
                                     settings.Settings.ShowFilterRow = True
                                     settings.Settings.ShowGroupPanel = True
                                     settings.Settings.ShowFooter = True

                                     settings.Columns.Add("Title", MVCxGridViewColumnType.TextBox).Width = Unit.Percentage(70)
                                 End Sub).BindToLINQ(String.Empty, String.Empty, Sub(s, e)
                                                                                     e.KeyExpression = "Oid"
                                                                                     Dim session As DevExpress.Xpo.Session = XpoHelper.GetNewSession()
                                                                                     Dim query As New DevExpress.Xpo.XPQuery(Of MyObject)(session)
                                                                                     e.QueryableSource = query
                                                                                 End Sub).GetHtml()
