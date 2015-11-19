# coding: utf-8

import sys
from setuptools import setup, find_packages

NAME = "rakam_client"
VERSION = "0.2"



# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = ["urllib3 >= 1.10", "six >= 1.9", "certifi", "python-dateutil"]

setup(
    name=NAME,
    version=VERSION,
    description="Rakam API Documentation",
    author_email="contact@rakam.com",
    url="",
    keywords=["Swagger", "Rakam API Documentation"],
    install_requires=REQUIRES,
    packages=find_packages(),
    include_package_data=True,
    long_description="""\
    An analytics platform API that lets you create your own analytics services.
    """
)


