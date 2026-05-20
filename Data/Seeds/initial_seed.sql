PROC_GET_LOGIN(
    IN P_ALIAS VARCHAR(30),
    IN P_CLAVE VARCHAR(200)
)
proc: BEGIN

    DECLARE V_VALID INT DEFAULT 0;
    DECLARE V_MESSAGE VARCHAR(300) DEFAULT 'Usuario o Contraseña incorrecta';
    DECLARE V_ID_USER INT DEFAULT NULL;
    DECLARE V_NAME VARCHAR(50);
    DECLARE V_correo VARCHAR(100);
    DECLARE V_ES_ADMIN INT;
    DECLARE V_LOW_DATE DATE;
    DECLARE V_CHANGE_PASSWORD_DATE DATE;
    DECLARE V_restaurada SMALLINT;
    DECLARE V_confirmada SMALLINT;
    DECLARE V_ID_ROL INT;

    SELECT 
        U.idUsuario,
        U.nombreCompleto,
        U.correo,
        U.admin ,
        U.fechaBaja ,
        U.changePassowrdDate,
        U.restaurada,
        U.confirmada
    INTO 
        V_ID_USER,
        V_NAME,
        V_correo,
        V_ES_ADMIN,
        V_LOW_DATE,
        V_CHANGE_PASSWORD_DATE,
        V_restaurada,
        V_confirmada
    FROM Users U
    WHERE 
        (UPPER(U.userName) = UPPER(P_ALIAS) 
         OR UPPER(U.correo) = UPPER(P_ALIAS))
        AND U.password = P_CLAVE
    LIMIT 1;

    IF V_ID_USER IS NULL THEN
        SELECT 0 AS VALID,
               V_MESSAGE AS MESSAGE,
               NULL,NULL,NULL,NULL,NULL,NULL,NULL;
        LEAVE proc;
    END IF;

    SELECT UR.idRol 
    INTO V_ID_ROL
    FROM RolesUsuarios UR
    WHERE UR.idUsuario = V_ID_USER
    LIMIT 1;

    IF V_ID_ROL IS NULL THEN
        SET V_MESSAGE = 'Usted no tiene permisos para acceder al sistema';
        SET V_ID_USER = 0;
        SET V_NAME = 0;
        SET V_correo = 0;
        SET V_ES_ADMIN = 0;
        SET V_LOW_DATE = 0;
        SET V_CHANGE_PASSWORD_DATE = 0;
        SET V_restaurada = 0;
        SET V_confirmada = 0;
    
        INSERT INTO LoginHistory(idUsuario,userName,valid,message)
        VALUES(V_ID_USER, V_NAME, 0, V_MESSAGE);

        SELECT 0 AS VALID,
               V_MESSAGE AS MESSAGE,
                   V_ID_USER,
    V_NAME,
    V_correo,
    V_ES_ADMIN,
    V_LOW_DATE,
    V_CHANGE_PASSWORD_DATE,
    V_restaurada,
    V_confirmada;
        LEAVE proc;
    END IF;

    IF V_LOW_DATE IS NOT NULL THEN
        SET V_MESSAGE = 'El usuario se encuentra deshabilitado';
        SET V_ID_USER = 0;
        SET V_NAME = 0;
        SET V_correo = 0;
        SET V_ES_ADMIN = 0;
        SET V_LOW_DATE = 0;
        SET V_CHANGE_PASSWORD_DATE = 0;
        SET V_restaurada = 0;
        SET V_confirmada = 0;
    
        INSERT INTO LoginHistory(idUsuario,userName,valid,message)
        VALUES(V_ID_USER, V_NAME, 0, V_MESSAGE);

        SELECT 0 AS VALID,
               V_MESSAGE AS MESSAGE,
                   V_ID_USER,
    V_NAME,
    V_correo,
    V_ES_ADMIN,
    V_LOW_DATE,
    V_CHANGE_PASSWORD_DATE,
    V_restaurada,
    V_confirmada;
        LEAVE proc;
    END IF;

    IF V_CHANGE_PASSWORD_DATE IS NOT NULL 
       AND V_CHANGE_PASSWORD_DATE <= CURDATE() THEN

        SET V_MESSAGE = 'Su contraseña se encuentra vencida, debe cambiarla';
        SET V_ID_USER = 0;
        SET V_NAME = 0;
        SET V_correo = 0;
        SET V_ES_ADMIN = 0;
        SET V_LOW_DATE = 0;
        SET V_CHANGE_PASSWORD_DATE = 0;
        SET V_restaurada = 0;
        SET V_confirmada = 0;
        
        INSERT INTO LoginHistory(idUsuario,userName,valid,message)
        VALUES(V_ID_USER, V_NAME, 0, V_MESSAGE);

        SELECT 0 AS VALID,
               V_MESSAGE AS MESSAGE,
                   V_NAME,
    V_correo,
    V_ES_ADMIN,
    V_LOW_DATE,
    V_CHANGE_PASSWORD_DATE,
    V_restaurada,
    V_confirmada;
        LEAVE proc;
    END IF;

    SET V_VALID = 1;
    SET V_MESSAGE = 'Bienvenido al Sistema';

    INSERT INTO LoginHistory(idUsuario,userName,valid,message)
    VALUES(V_ID_USER, V_NAME, V_VALID, V_MESSAGE);

    SELECT V_VALID AS VALID,
           V_MESSAGE AS MESSAGE,
           V_ID_USER AS ID_USER,
           V_NAME AS NAME,
           V_correo AS correo,
           V_ES_ADMIN AS ES_ADMIN,
           V_CHANGE_PASSWORD_DATE AS CHANGE_PASSWORD_DATE,
           V_restaurada AS restaurada,
           V_confirmada AS confirmada;

END;