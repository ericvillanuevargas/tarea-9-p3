import sqlite3
from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware
from pydantic import BaseModel
app = FastAPI()

origins = ["*"]
app.add_middleware(
    CORSMiddleware,
    allow_origins=origins,
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)
class Solicitud(BaseModel):
    Cedula:str
    Nombre:str
    Apellido:str
    Telefono:str
    Correo:str
    Fecha_Nacimiento:str
    Tipo_Sangre:str
    Provincia:str
    Direccion:str
    Longitud:str
    Latitud:str
    Vacunacion:str
    Justificacion:str


@app.get("/")
def root():
    return {'Sistema': 'Solicitud de vacunacion'}

@app.post("/api/RegistrarSolicitudVacunacion")
def RegistrarSolicitudVacunacion(d:Solicitud):
    try:
        Cedul=""
        conexion = sqlite3.connect('BaseDeDatos.db')
        cursor = conexion.cursor()
        cursor.execute("SELECT Cedula FROM SolicitudVacunacion WHERE Cedula = '"+d.Cedula+"'")
        contenido = cursor.fetchall()
        for i in contenido:
            Cedul = i[0]
        if d.Cedula == Cedul:
            return {"ok":False}
        else:
            Datos = (d.Cedula,
                    d.Nombre,
                    d.Apellido,
                    d.Telefono,
                    d.Correo,
                    d.Fecha_Nacimiento,
                    d.Tipo_Sangre,
                    d.Provincia,
                    d.Direccion,
                    d.Longitud,
                    d.Latitud,
                    d.Vacunacion,
                    d.Justificacion);
            Sql = '''INSERT INTO SolicitudVacunacion(Cedula,
                        Nombre,
                        Apellido,
                        Telefono,
                        Correo,
                        Fecha_Nacimiento,
                        Tipo_Sangre,
                        Provincia,
                        Direccion,
                        Longitud,
                        Latitud,
                        Vacunacion,
                        Justificacion)VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?)'''
            cursor.execute(Sql,Datos)
            conexion.commit()
            return {"ok":True}
    except:
        return {"ok":False}

@app.get("/api/ConsultaSolicitudesGeneral")
def ConsultaSolicitudesGeneral():
    try:
        Lista = []
        conexion = sqlite3.connect('BaseDeDatos.db')
        cursor = conexion.cursor()
        cursor.execute("SELECT * FROM SolicitudVacunacion")
        contenido = cursor.fetchall()
        for i in contenido:
            Lista.append({"IdSolicitud":i[0],"Cedula":i[1],
                            "Nombre":i[2],
                            "Apellido":i[3],
                            "Telefono":i[4],
                            "Correo":i[5],
                            "Fecha_Nacimiento":i[6],
                            "Tipo_Sangre":i[7],
                            "Provincia":i[8],
                            "Direccion":i[9],
                            "Longitud":i[10],
                            "Latitud":i[11],
                            "Vacunacion":i[12],
                            "Justificacion":i[13]})
        if Lista == []:
            return {"ok":False}
        else:
            return {"ok":True, "data":Lista}
    except:
        return {"ok":False}

@app.get("/api/ConsultaSolicitudesUnica/{IdSolicitud}")
def ConsultaSolicitudesUnica(IdSolicitud:str):
    try:
        Lista = []
        conexion = sqlite3.connect('BaseDeDatos.db')
        cursor = conexion.cursor()
        cursor.execute("SELECT * FROM SolicitudVacunacion WHERE IdSolicitud = '"+IdSolicitud+"'")
        contenido = cursor.fetchall()
        for i in contenido:
            Lista.append({"IdSolicitud":i[0],"Cedula":i[1],
                            "Nombre":i[2],
                            "Apellido":i[3],
                            "Telefono":i[4],
                            "Correo":i[5],
                            "Fecha_Nacimiento":i[6],
                            "Tipo_Sangre":i[7],
                            "Provincia":i[8],
                            "Direccion":i[9],
                            "Longitud":i[10],
                            "Latitud":i[11],
                            "Vacunacion":i[12],
                            "Justificacion":i[13]})
        if Lista == []:
            return {"ok":False}
        else:
            return Lista
    except:
        return {"ok":False}

@app.delete("/api/EliminarConsultaSolicitudes/{IdSolicitud}")
def EliminarConsultaSolicitudes(IdSolicitud:str):
    try:
        conexion = sqlite3.connect('BaseDeDatos.db')
        cursor = conexion.cursor()
        cursor.execute("DELETE FROM SolicitudVacunacion WHERE IdSolicitud = '"+IdSolicitud+"'")
        conexion.commit()
        return {"ok":True}
    except:
        return {"ok":False}