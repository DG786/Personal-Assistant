import os
import sys



systemdrivename=os.getenv('systemdrive')


import os.path
dl = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
iterdrives = ['%s:' % d for d in dl if os.path.exists('%s:' % d)]
iterdrives.remove(systemdrivename)

del sys.argv[0]

joinerspace=' '

aline =joinerspace.join(sys.argv) 
bline=aline.strip()
line=bline.lower()
pieces=line.split()


firstspace=line.find(' ')

if firstspace==-1:
	exit()

if ('search' in line) or ('find' in line) or ('run' in line) or ('execute' in line) or ('open' in line) or ('play' in line):
	afname=line[firstspace:]
	fname=afname.strip()

	if pieces[-1]=='folder':
		use1fname=fname[:len(fname)-6]
		ause1fname=use1fname.strip()
		for drivename in iterdrives:
			for (dirname,dirs,files) in os.walk(drivename):
				for dir in dirs:
					lowerdir=dir.lower()
					if ause1fname in lowerdir:
						folderpath=os.path.join(dirname,dir)
						breakpath=folderpath.split('\\')
						delimiter='\\\\'
						joinedpath=delimiter.join(breakpath)
						os.startfile(joinedpath) 
						exit()
	
	if pieces[-1]=='file':
		use2fname=fname[:len(fname)-4]
		ause2fname=use2fname.strip()
		for drivename in iterdrives:
			for (dirname,dirs,files) in os.walk(drivename):
				for file in files:
					lowerfile=file.lower()
					if ause2fname in lowerfile:
						filepath=os.path.join(dirname,file)
						breakpath=filepath.split('\\')
						delimiter='\\\\'
						joinedpath=delimiter.join(breakpath)
						os.startfile(joinedpath) 
						exit()
	for drivename in iterdrives:
		for (dirname,dirs,files) in os.walk(drivename):
			for dir in dirs:
				lowerdir=dir.lower()
				if fname in lowerdir:
					folderpath=os.path.join(dirname,dir)
					breakpath=folderpath.split('\\')
					delimiter='\\\\'
					joinedpath=delimiter.join(breakpath)
					os.startfile(joinedpath) 
					exit()
		
			for file in files:
				lowerfile=file.lower()
				if fname in lowerfile:
					filepath=os.path.join(dirname,file)
					breakpath=filepath.split('\\')
					delimiter='\\\\'
					joinedpath=delimiter.join(breakpath)
					os.startfile(joinedpath) 
					exit()