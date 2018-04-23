@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "PersonID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.SettingsEditing.Mode = GridViewEditingMode.Inline
            settings.SettingsEditing.AddNewRowRouteValues = New With {.Controller = "Home", .Action = "EditingAddNew"}
            settings.SettingsEditing.UpdateRowRouteValues = New With {.Controller = "Home", .Action = "EditingUpdate"}
            settings.SettingsEditing.DeleteRowRouteValues = New With {.Controller = "Home", .Action = "EditingDelete"}

            settings.ControlStyle.CssClass = "GridViewRootClassName"
    
            '/*Command Column Emulation*/
            settings.Columns.Add( _
                Sub(column)
                        column.Caption = "#"

                        '/*DataItemTemplate*/
                        '/*New - Edit - Delete Buttons*/
                        column.SetDataItemTemplateContent( _
                            Sub(c)
                                    ViewContext.Writer.Write(String.Format("<span class=""glyphicon glyphicon-plus"" onclick=""{0}.AddNewRow();""></span>", settings.Name))

                                    ViewContext.Writer.Write("&nbsp;")

                                    ViewContext.Writer.Write(String.Format("<span class=""glyphicon glyphicon-pencil"" onclick=""{0}.StartEditRow('{1}');""></span>", settings.Name, c.VisibleIndex))

                                    ViewContext.Writer.Write("&nbsp;")

                                    ViewContext.Writer.Write(String.Format("<span class=""glyphicon glyphicon-remove"" onclick=""{0}.DeleteRow('{1}');""></span>", settings.Name, c.VisibleIndex))

                            End Sub)
                        '/*DataItemTemplate*/

                        '/*EditItemTemplate*/
                        column.SetEditItemTemplateContent( _
                            Sub(c)
                                    ViewContext.Writer.Write(String.Format("<span class=""glyphicon glyphicon-ok"" onclick=""{0}.UpdateEdit();""></span>", settings.Name))

                                    ViewContext.Writer.Write("&nbsp;")

                                    ViewContext.Writer.Write(String.Format("<span class=""glyphicon glyphicon-repeat"" onclick=""{0}.CancelEdit();""></span>", settings.Name))
                            End Sub)
                        '/*EditItemTemplate*/

                End Sub)
            '/*Command Column Emulation*/

            settings.Columns.Add("FirstName")
            settings.Columns.Add("MiddleName")
            settings.Columns.Add("LastName")

            settings.CellEditorInitialize = _
                Sub(s, e)
                        Dim editor As ASPxEdit = DirectCast(e.Editor, ASPxEdit)
                        editor.ValidationSettings.Display = Display.Dynamic
                End Sub
    End Sub).Bind(Model).GetHtml()