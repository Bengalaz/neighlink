# NEIGHLINK

![](https://i.ibb.co/kMNQ7j4/138d6b3a-9571-4026-bc29-700b5af1b394.jpg)

## TABLA DE CONTENIDO
1. [DESCRIPCIÓN DE LA STARTUP](#descripción-de-la-startup)
2. [HISTORIAS DE USUARIO](#historias-de-usuario)
3. [DIAGRAMA DE CLASES](#diagrama-de-clases)
4. [DIAGRAMA DE BASE DE DATOS](#diagrama-de-base-de-datos)


## DESCRIPCIÓN DE LA STARTUP

**Misión**
<br>
Proveer una herramienta de software que ayude en la administración de condominios, edificios o residencias, permitiendo que la comunicación entre los residentes y el administrador sea más rápida y efectiva.

**Visión**
<br>
Lograr optimizar el tiempo de los administradores y mejorar la experiencia
de los residentes. Asimismo, posicionarse como uno de los mejores
sistemas de gestión de condominios y edificios en Latinoamérica.


## HISTORIAS DE USUARIO

<table>
  <tr>
      <th colspan="2"><b>Historia de usuario</b></th>
  </tr>
  <tr>
      <td><b>Número:</b> RF01</td>
    <td><b>Usuario:</b> Usuario</td>
  </tr>
  <tr>
    <td colspan="2"><b>Nombre de historia:</b> Sign up</td>
  </tr>
  <tr>
    <td><b>Prioridad en negocio:</b> </td>
    <td><b>Riesgo en desarrollo:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Programador responsable:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Descripción:</b> Como usuario quiero registrarme para poder acceder a la información de mi condominio o edificio.<br></td>
  </tr>
  <tr>
    <td colspan="2"><b>Criterios de aceptación:</b>
			<ul>
				<li>Dado que el usuario está en el primer paso de la sección “Regístrate” cuando ingrese el código de su condominio o edificio si es válido entonces lo llevará al siguiente paso para que coloque sus credenciales, caso contrario le mostrará un mensaje que el código no es válido.</li>
				<li>Dado que el usuario está en el segundo paso de la sección “Regístrate” cuando ingrese sus credenciales (email y password) entonces se validará que sea un nuevo email, si es así se redirecciona a la vista principal, caso contrario se muestra una mensaje que ya existe ese email.</li>
			</ul>
    </td>
  </tr>
</table>

<table>
  <tr>
      <th colspan="2"><b>Historia de usuario</b></th>
  </tr>
  <tr>
      <td><b>Número:</b> RF02</td>
    <td><b>Usuario:</b> Usuario</td>
  </tr>
  <tr>
    <td colspan="2"><b>Nombre de historia:</b> Log in</td>
  </tr>
  <tr>
    <td><b>Prioridad en negocio:</b> </td>
    <td><b>Riesgo en desarrollo:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Programador responsable:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Descripción:</b> Como usuario quiero iniciar sesión para poder acceder a la información de mi condominio o edificio.<br></td>
  </tr>
  <tr>
    <td colspan="2"><b>Criterios de aceptación:</b>
			<ul>
				<li>Dado que el usuario está en el primer paso de la sección “Inicia Sesión” cuando ingrese el código de su condominio o edificio si es válido entonces lo llevará al siguiente paso para que coloque sus credenciales, caso contrario le mostrará un mensaje que el código no es válido.</li>
				<li>Dado que el usuario está en el segundo paso de la sección “Inicia Sesión” cuando ingrese sus credenciales (email y password) entonces se validará que su email esté registrado, si es así se redirecciona a la vista principal, caso contrario se mostrará un mensaje que las credenciales son inválidas.</li>
			</ul>
    </td>
  </tr>
</table>

<table>
  <tr>
      <th colspan="2"><b>Historia de usuario</b></th>
  </tr>
  <tr>
      <td><b>Número:</b> RF03</td>
    <td><b>Usuario:</b> Usuario</td>
  </tr>
  <tr>
    <td colspan="2"><b>Nombre de historia:</b> Editar perfil</td>
  </tr>
  <tr>
    <td><b>Prioridad en negocio:</b> </td>
    <td><b>Riesgo en desarrollo:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Programador responsable:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Descripción:</b> Como usuario quiero editar mi perfil para poder actualizar mis datos.<br></td>
  </tr>
  <tr>
    <td colspan="2"><b>Criterios de aceptación:</b>
			<ul>
				<li>Dado que el usuario está en la vista "Editar perfil" cuando haga clic en Guardar se validará si los campos obligatorios han sido llenados entonces si es así se mostrará un mensaje "Se actulizó tu perfil correctamente", caso contrario se mostrará el mensaje "Por favor, completa los campos obligatorios".</li>
			</ul>
    </td>
  </tr>
</table>

<table>
  <tr>
      <th colspan="2"><b>Historia de usuario</b></th>
  </tr>
  <tr>
      <td><b>Número:</b> RF04</td>
    <td><b>Usuario:</b> Administrador</td>
  </tr>
  <tr>
    <td colspan="2"><b>Nombre de historia:</b> Registrar nombre de edificios</td>
  </tr>
  <tr>
    <td><b>Prioridad en negocio:</b> </td>
    <td><b>Riesgo en desarrollo:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Programador responsable:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Descripción:</b> Como administrador quiero registrar el nombre de los edificios que hay en el condominio para tener sectorizado a los residentes.<br></td>
  </tr>
  <tr>
    <td colspan="2"><b>Criterios de aceptación:</b>
			<ul>
				<li>Dado que el administrador se encuentra en la vista "Configuración" cuando quiera añadir el nombre de un edificio entonces le aparecerá un pequeño formulario con los campos nombre y descripción.</li>
			</ul>
    </td>
  </tr>
</table>

<table>
  <tr>
      <th colspan="2"><b>Historia de usuario</b></th>
  </tr>
  <tr>
      <td><b>Número:</b> </td>
    <td><b>Usuario:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Nombre de historia:</b> </td>
  </tr>
  <tr>
    <td><b>Prioridad en negocio:</b> </td>
    <td><b>Riesgo en desarrollo:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Programador responsable:</b> </td>
  </tr>
  <tr>
    <td colspan="2"><b>Descripción:</b> <br></td>
  </tr>
  <tr>
    <td colspan="2"><b>Criterios de aceptación:</b>
			<ul>
				<li></li>
			</ul>
    </td>
  </tr>
</table>

## DIAGRAMA DE CLASES

![](https://i.ibb.co/8gsnK6f/diagramaluccid.png)


## DIAGRAMA DE BASE DE DATOS

![](https://i.ibb.co/zH2TSQz/WEB-2019-09-14-13-10.png)
