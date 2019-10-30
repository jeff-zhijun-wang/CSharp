from bottle import request, response
from bottle import post, get, put, delete

_names = set()

@post('/names')
def creation_handle():
    pass

@get('/names')
def listing_handler():
    '''Handle name listing'''
    pass

@put('/names/<name>')
def update_handler(name):
    '''Handles name updates'''
    pass

@delete('/names/<name>')
def delete_handler(name):
    pass



