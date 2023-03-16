# JuegoUnity

## Brebe explicacion:


* _El mapa consta de 3 zonas, una zona de laberinto de rocas, una zona donde hay una plataforma y una zona de enemigos._

* _El pack de rocas me lo descargue de la unity asset store juto con los materiales y texturas._

* _El juego cuenta con 5 scripts y 1 trigger._




![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/juego%20explicacion.PNG)


# Configuraciones:

### _Configuracion camara_ ###
![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/config%20camara.PNG)
---
### _Configuracion jugador_ ###
![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/config%20jugador.PNG)
---
### _Configuracion enemigos_ ###
![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/enemigos%20config.PNG)
---
### _Configuracion plataforma_ ###
![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/plataforma%20config.PNG)
---
### _Configuracion rocas_ ###
![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/rocas%20config.PNG)
---


### _Contenido carpeta Assets:_ ###

![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/assets.PNG)
---


# Explicacion de los scripts y trigges con ejemplos:

### Aumento de velocidad ###

* Básicamente lo que hace este script es que mientras esté presionada la letra ctrl izquierda, aumente la velocidad del jugador.

![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/ctrlmasvelocidad.gif)


### Camara en primera persona y movimiento de jugador ###

* PAra ello utilicé 3 scripts, dos para controlar el movimiento, que son Player controller y movimiento teclas y otro llamado camerapp para la primera persona.

![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/movimientoYcamara.gif)


### Ataque de enemigos y tp al inicio ###

* Para ello utilicé el script llamado enemigos, el cual hace que si el jugador se acerca a x distancia de ellos, le empiezan a perseguir y si es pillado, vuelve a la posición inicial.

![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/enemigotp.gif)


### Apertura de puerta ###

* Para ello utilicé un trigger llamdao TiggerPlatform aplicado en una plataforma, en la cual cuando el jugador pasa por encima, una de las piedras del laberinto se eleva para dejarle paso.

![](https://github.com/davidbrodrigues/JuegoUnity/blob/dfeb9ea2e59579d9a108147587c8ed88490e70a0/FotosGIFS/plataformapuerta.gif)
---

