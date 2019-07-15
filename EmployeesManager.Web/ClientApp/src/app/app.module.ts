import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { SettingsComponent } from './components/settings/settings.component';
import { MenuComponent } from './components/menu/menu.component';
import { EmployeeService } from './services/employee.service';
import { AuthenticationService } from './services/authentication.service';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ListEmployeesComponent } from './components/list-employees/list-employees.component';
import { CreateEmployeesComponent } from './components/create-employees/create-employees.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    SettingsComponent,
    MenuComponent,
    ListEmployeesComponent,
    CreateEmployeesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'Listar', component: ListEmployeesComponent },
      { path: 'Novo', component: CreateEmployeesComponent }
    ])
  ],
  providers: [
    EmployeeService,
    AuthenticationService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
