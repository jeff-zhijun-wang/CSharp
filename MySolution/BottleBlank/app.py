#"""
#This script runs the application using a development server.
#It contains the definition of routes and views for the application.
#"""

#import os
#import sys
#from bottle import default_app, redirect, route, template

#if '--debug' in sys.argv[1:] or 'SERVER_DEBUG' in os.environ:
#    # Debug mode will enable more verbose output in the console window.
#    # It must be set at the beginning of the script.
#    import bottle
#    bottle.debug(True)


#@route('/')
#def hello():
#    """Renders a sample page."""
#    redirect('/hello/world')

#@route('/hello/<name>')
#def example(name):
#    """Renders a sample page with the name specified in the URL."""
#    return template('<b>Hello {{name}}</b>!', name=name)



#def wsgi_app():
#    """Returns the application to make available through wfastcgi.  This is
#    used
#    when the site is published to Microsoft Azure."""
#    return default_app()

#if __name__ == '__main__':
#    # Starts a local test server.
#    HOST = os.environ.get('SERVER_HOST', 'localhost')
#    try:
#        PORT = int(os.environ.get('SERVER_PORT', '5555'))
#    except ValueError:
#        PORT = 5555
#    import bottle
#    bottle.run(server='wsgiref', host=HOST, port=PORT)

#!/usr/bin/env python3

#!/usr/bin/env python3

from bottle import route, run, template, HTTPResponse
from pymongo import MongoClient

client = MongoClient('mongodb://localhost:8887/')

@route('/cars')
def getcars():

    db = client.testdb
    data = db.cars.find({}, {'_id': 0})

    if data:

        return template('show_cars', cars=data)
    else: 
        return HTTPResponse(status=204)


run(host='localhost', port=8887, debug=True)